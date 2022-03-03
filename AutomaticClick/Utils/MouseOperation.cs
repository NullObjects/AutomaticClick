using System.Runtime.InteropServices;

namespace AutomaticClick.Utils
{
    /// <summary>
    /// 鼠标操作
    /// </summary>
    public static class MouseOperation
    {
        [DllImport("user32")]
        public static extern int mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        //移动鼠标 
        public const int MOUSEEVENTF_MOVE = 0x0001;

        //模拟鼠标左键按下 
        public const int MOUSEEVENTF_LEFTDOWN = 0x0002;

        //模拟鼠标左键抬起 
        public const int MOUSEEVENTF_LEFTUP = 0x0004;

        //模拟鼠标右键按下 
        public const int MOUSEEVENTF_RIGHTDOWN = 0x0008;

        //模拟鼠标右键抬起 
        public const int MOUSEEVENTF_RIGHTUP = 0x0010;

        //模拟鼠标中键按下 
        public const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;

        //模拟鼠标中键抬起 
        public const int MOUSEEVENTF_MIDDLEUP = 0x0040;

        //标示是否采用绝对坐标 
        public const int MOUSEEVENTF_ABSOLUTE = 0x8000;

        //模拟鼠标滚轮滚动操作，必须配合dwData参数
        public const int MOUSEEVENTF_WHEEL = 0x0800;
    }
}