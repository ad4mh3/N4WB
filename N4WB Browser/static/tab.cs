using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace N4WB_Browser
{
    internal class tab
    {
        internal string identifier { get; set; } = "UNDEFINED";
        internal ChromiumWebBrowser browserObject { get; set; } = null;
        internal TabPage tabObject { get; set; } = null;
    }
}
