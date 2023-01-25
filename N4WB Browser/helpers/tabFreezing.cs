using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace N4WB_Browser.helpers
{
    internal static class tabFreezing
    {
        /// <summary>
        /// Freezes a tab
        /// </summary>
        /// <param name="identifier">Tab to freeze</param>
        internal static void freeze(string identifier)
        {
            // Get tab from helper
            tab thisTab = tabControls.find(identifier);

            // Hide browser in tab if not already
            if(thisTab.browserObject.Visible)
                thisTab.browserObject.Visible = false;

            // Disable browser in tab if not already
            if (thisTab.browserObject.Enabled)
                thisTab.browserObject.Enabled = false;
        }

        /// <summary>
        /// Unfreezes a tab
        /// </summary>
        /// <param name="identifier">Tab to unfreeze</param>
        internal static void unfreeze(string identifier)
        {
            // Get tab from helper
            tab thisTab = tabControls.find(identifier);

            // Show browser in tab if not already
            if (!thisTab.browserObject.Visible) 
                thisTab.browserObject.Visible = true;

            // Enable browser in tab if not already
            if (!thisTab.browserObject.Enabled)
                thisTab.browserObject.Enabled = true;
        }
    }
}
