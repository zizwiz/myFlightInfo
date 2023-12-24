using System;
using System.Runtime.InteropServices;
using System.Text;

namespace CenteredMessagebox
{
	public class Win32
	{
		#region Values & structs

		public const int WH_CBT = 5;
		public const int HCBT_ACTIVATE = 5;


		[StructLayout(LayoutKind.Sequential)]
		public struct RECT
		{
			public int left;
			public int top;
			public int right;
			public int bottom;
		}

		#endregion Values & structs


		#region Stock P/Invokes

		// Arg for SetWindowsHookEx()
		public delegate int WindowsHookProc(int nCode, IntPtr wParam, IntPtr lParam);

		[DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
		public static extern int SetWindowsHookEx(int idHook, WindowsHookProc lpfn, IntPtr hInstance, int threadId);

		[DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
		public static extern bool UnhookWindowsHookEx(int idHook);

		[DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
		public static extern int CallNextHookEx(int idHook, int nCode, IntPtr wParam, IntPtr lParam);

		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		public static extern int GetWindowTextLength(IntPtr hWnd);

		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

		[DllImport("user32.dll")]
		public static extern uint GetDlgItemText(IntPtr hDlg, int nIDDlgItem, [Out] StringBuilder lpString, int nMaxCount);

		[DllImport("user32.dll")]
		public static extern IntPtr GetDlgItem(IntPtr hDlg, int nIDDlgItem);

		[DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
		public static extern IntPtr GetParent(IntPtr hWnd);

		[DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetWindowRect(IntPtr handle, ref RECT r);

		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

		#endregion Stock P/Invokes


		#region Simplified interfaces

		public static string GetClassName(IntPtr hWnd)
		{
			StringBuilder ClassName = new StringBuilder(100);
			//Get the window class name
			int nRet = GetClassName(hWnd, ClassName, ClassName.Capacity);
			return ClassName.ToString();
		}

		public static string GetWindowText(IntPtr hWnd)
		{
			// Allocate correct string length first
			int length = GetWindowTextLength(hWnd);
			StringBuilder sb = new StringBuilder(length + 1);
			GetWindowText(hWnd, sb, sb.Capacity);
			return sb.ToString();
		}

		public static string GetDlgItemText(IntPtr hDlg, int nIDDlgItem)
		{
			IntPtr hItem = GetDlgItem(hDlg, nIDDlgItem);
			if (hItem == IntPtr.Zero)
				return null;
			int length = GetWindowTextLength(hItem);
			StringBuilder sb = new StringBuilder(length + 1);
			GetWindowText(hItem, sb, sb.Capacity);
			return sb.ToString();
		}

		#endregion Simplified interfaces


	}
}