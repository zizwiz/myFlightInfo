using System;
using System.Windows.Forms;

namespace CenteredMessagebox
{
	public class MsgBox
	{
		private static Win32.WindowsHookProc _hookProcDelegate = null;
		private static int _hHook = 0;
		private static string _title = null;
		private static string _msg = null;

		public static DialogResult Show(string msg, string title, MessageBoxButtons btns, MessageBoxIcon icon)
		{
			// Create a callback delegate
			_hookProcDelegate = new Win32.WindowsHookProc(HookCallback);

			// Remember the title & message that we'll look for.
			// The hook sees *all* windows, so we need to make sure we operate on the right one.
			_msg = msg;
			_title = title;

			// Set the hook.
			// Suppress "GetCurrentThreadId() is deprecated" warning. 
			// It's documented that Thread.ManagedThreadId doesn't work with SetWindowsHookEx()
#pragma warning disable 0618
			_hHook = Win32.SetWindowsHookEx(Win32.WH_CBT, _hookProcDelegate, IntPtr.Zero, AppDomain.GetCurrentThreadId());
#pragma warning restore 0618

			// Pop a standard MessageBox. The hook will center it.
			DialogResult rslt = MessageBox.Show(msg, title, btns, icon);

			// Release hook, clean up (may have already occurred)
			Unhook();

			return rslt;
		}

		private static void Unhook()
		{
			Win32.UnhookWindowsHookEx(_hHook);
			_hHook = 0;
			_hookProcDelegate = null;
			_msg = null;
			_title = null;
		}

		private static int HookCallback(int code, IntPtr wParam, IntPtr lParam)
		{
			int hHook = _hHook; // Local copy for CallNextHookEx() JIC we release _hHook

			// Look for HCBT_ACTIVATE, *not* HCBT_CREATEWND:
			//   child controls haven't yet been created upon HCBT_CREATEWND.
			if (code == Win32.HCBT_ACTIVATE)
			{
				string cls = Win32.GetClassName(wParam);
				if (cls == "#32770")    // MessageBoxes are Dialog boxes
				{
					string title = Win32.GetWindowText(wParam);
					string msg = Win32.GetDlgItemText(wParam, 0xFFFF);  // -1 aka IDC_STATIC
					if ((title == _title) && (msg == _msg))
					{
						CenterWindowOnParent(wParam);
						Unhook();   // Release hook - we've done what we needed
					}
				}
			}
			return Win32.CallNextHookEx(hHook, code, wParam, lParam);
		}

		// Boilerplate window-centering code.
		// Split out of HookCallback() for clarity.
		private static void CenterWindowOnParent(IntPtr hChildWnd)
		{
			// Get child (MessageBox) size
			Win32.RECT rcChild = new Win32.RECT();
			Win32.GetWindowRect(hChildWnd, ref rcChild);
			int cxChild = rcChild.right - rcChild.left;
			int cyChild = rcChild.bottom - rcChild.top;

			// Get parent (Form) size & location
			IntPtr hParent = Win32.GetParent(hChildWnd);
			Win32.RECT rcParent = new Win32.RECT();
			Win32.GetWindowRect(hParent, ref rcParent);
			int cxParent = rcParent.right - rcParent.left;
			int cyParent = rcParent.bottom - rcParent.top;

			// Center the MessageBox on the Form
			int x = rcParent.left + (cxParent - cxChild) / 2;
			int y = rcParent.top + (cyParent - cyChild) / 2;
			uint uFlags = 0x15; // SWP_NOSIZE | SWP_NOZORDER | SWP_NOACTIVATE;
			Win32.SetWindowPos(hChildWnd, IntPtr.Zero, x, y, 0, 0, uFlags);
		}


	}
}