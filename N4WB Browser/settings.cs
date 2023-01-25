using N4WB_Browser.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace N4WB_Browser
{
    internal static class settings
    {
        internal static string Useragent = "";
        internal static bool Tasks = false;
        internal static bool Javascript = true;
        internal static bool Images = true;
        internal static bool CompatTextRendering = false;
        internal static bool AutoFreezeTabs = false;

        internal static void load()
        {
            /*
            * Import settings from registry
            */

            // Appearance
            if (registry.exists("AppearanceMode"))
                switch (registry.get("AppearanceMode"))
                {
                    case "0":
                        theming.theme.MainBackColour = System.Drawing.Color.FromArgb(240, 240, 240);
                        theming.theme.MainForeColour = System.Drawing.Color.Black;
                        break;
                    case "1":
                        theming.theme.MainBackColour = System.Drawing.Color.FromArgb(35,35,35);
                        theming.theme.MainForeColour = System.Drawing.Color.White;
                        break;
                    case "2":
                        theming.theme.MainBackColour = System.Drawing.Color.Black;
                        theming.theme.MainForeColour = System.Drawing.Color.White;
                        break;
                }
            else
            {
                registry.set("AppearanceMode", "0");
                theming.theme.MainBackColour = System.Drawing.Color.FromArgb(240, 240, 240);
                theming.theme.MainForeColour = System.Drawing.Color.Black;
            }

            // Javascript
            if (registry.exists("Javascript"))
                switch (registry.get("Javascript"))
                {
                    case "0":
                        Javascript = false;
                        break;
                    case "1":
                        Javascript = true;
                        break;
                }
            else
            {
                registry.set("Javascript", "0");
                Javascript = false;
            }

            // Images
            if (registry.exists("Images"))
                switch (registry.get("Images"))
                {
                    case "0":
                        Images = false;    
                        break;
                    case "1":
                        Images = true;
                        break;
                }
            else
            {
                registry.set("Images", "1");
                Images = true;
            }

            // Auto-freezing of tabs
            if (registry.exists("TabAutoFreeze"))
                switch (registry.get("TabAutoFreeze"))
                {
                    case "0":
                        AutoFreezeTabs = false;
                        break;
                    case "1":
                        AutoFreezeTabs = true;
                        break;
                }
            else
            {
                registry.set("TabAutoFreeze", "0");
                AutoFreezeTabs = false;
            }

            // Compatible text rendering
            if (registry.exists("CompatibleTextRendering"))
                switch (registry.get("CompatibleTextRendering"))
                {
                    case "0":
                        CompatTextRendering = false;
                        break;
                    case "1":
                        CompatTextRendering = true;
                        break;
                }
            else
            {
                registry.set("CompatibleTextRendering", "0");
                CompatTextRendering = false;
            }

            // Tasks
            if (registry.exists("Tasks"))
                switch (registry.get("Tasks"))
                {
                    case "0":
                        Tasks = false;
                        break;
                    case "1":
                        Tasks = true;
                        break;
                }
            else
            {
                registry.set("Tasks", "0");
                Tasks = false;
            }

            // Useragent
            if (registry.exists("Useragent"))
                Useragent = registry.get("Useragent");
            else
            {
                registry.set("Useragent", "");
                Useragent = registry.get("Useragent");
            }
        }
    }
}
