﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SongSearch.Classes
{
    public static class ControlExtensions
    {
        public static void safeInvoke(this Control c, Action callback)
        {
            if (c.InvokeRequired)
            {
                c.Invoke(new MethodInvoker(() =>
                {
                    callback();
                }));
            }
            else
            {
                callback();
            }
        }

        public static void safeBeginInvoke(this Control c, Action callback)
        {
            if (c.InvokeRequired)
            {
                c.BeginInvoke(new MethodInvoker(() =>
                {
                    callback();
                }));
            }
            else
            {
                callback();
            }
        }
    }
}
