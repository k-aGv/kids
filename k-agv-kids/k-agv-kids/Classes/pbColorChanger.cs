using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace k_agv_kids
{
    
    public static class pbColorChanger
    {
       
      
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static int SetState( ProgressBar pBar, int state)
        {
           
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
            return state;
        }
       
    }
}
