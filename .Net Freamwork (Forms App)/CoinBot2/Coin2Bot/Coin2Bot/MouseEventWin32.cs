using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CoinBot
{
    class MouseEventWin32
    {
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;
        public static void SolMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            //Sol Tıkladı
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            //Sol Bıraktı
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }
        public static void SolMouseBasiliClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            //Sol Tıkladı
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
        }
        public static void SagMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            //Sağ Tıkladı
            mouse_event(MOUSEEVENTF_RIGHTDOWN, xpos, ypos, 0, 0);
            //Sağ Bıraktı
            mouse_event(MOUSEEVENTF_RIGHTUP, xpos, ypos, 0, 0);
        }
        public static void SagMouseBasiliClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            //Sağ Tıkladı
            mouse_event(MOUSEEVENTF_RIGHTDOWN, xpos, ypos, 0, 0);
        }

    }
}

