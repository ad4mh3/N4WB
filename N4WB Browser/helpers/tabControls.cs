using CefSharp.WinForms;
using N4WB_Browser.theming;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace N4WB_Browser.helpers
{
    internal static class tabControls
    {
        internal static List<tab> tabs = new List<tab>();

        /// <summary>
        /// Loads and adds an already-made tab into memory.
        /// </summary>
        /// <param name="tab">Tab to register</param>
        private static void register(tab tab)
        {
            if (!tabs.Contains(tab))
                tabs.Add(tab);
        }

        /// <summary>
        /// Finds and returns a tab
        /// </summary>
        /// <param name="identifier">Tab to find's identifier</param>
        /// <returns></returns>
        internal static tab find(string identifier)
        {
            foreach (tab x in tabs)
                if (x.identifier == identifier)
                    return x;

            return new tab();
        }

        /// <summary>
        /// Makes a new tab class with a specified URL. Also loads with memory so no need to call register.
        /// </summary>
        /// <param name="url">URL this tab should have</param>
        /// <returns>A usable tab object</returns>
        internal static tab make(string url)
        {
            // Append HTTP string if doesn't exist
            //if (!url.ToLower().Contains("http://") || !url.ToLower().Contains("https://"))
            //    url = "https://" + url;

            // Init new tab
            TabPage newTabObj = new TabPage();
            tab newTab = new tab();

            // Init new browser object
            ChromiumWebBrowser newChromeBrowser = new ChromiumWebBrowser(url);
            newChromeBrowser.LifeSpanHandler = new events.LifeSpanHandler();
            newChromeBrowser.BackColor = theming.theme.TabBackColour;

            /*
             * Set browser settings
             */

            // Set javascript enabled state
            if (settings.Javascript)
                newChromeBrowser.BrowserSettings.Javascript = CefSharp.CefState.Enabled;
            else
                newChromeBrowser.BrowserSettings.Javascript = CefSharp.CefState.Disabled;

            // Set images enabled state
            if (settings.Images)
                newChromeBrowser.BrowserSettings.ImageLoading = CefSharp.CefState.Enabled;
            else
                newChromeBrowser.BrowserSettings.ImageLoading = CefSharp.CefState.Disabled;

            // Generate and set new identifier
            newTab.identifier = new Random().Next(11111111, 999999999).ToString() + new Random().Next(11111111, 999999999).ToString();

            // Set tab and browser object
            newTab.browserObject = newChromeBrowser;
            newTab.tabObject = newTabObj;

            // Set tabpage elements
            newTabObj.BackColor = theming.theme.TabBackColour;
            newTabObj.ForeColor = theming.theme.TabForeColour;
            try { newTabObj.Text = url.Substring(0, 15) + "..."; } catch { newTabObj.Text = url; }
            newTabObj.Name = newTab.identifier; // set identifier as tab name so we can find this tab later
            newTabObj.Controls.Add(newChromeBrowser);
            newChromeBrowser.Dock = DockStyle.Fill;

            // Register with memory
            register(newTab);

            // Return tab to caller
            return newTab;
        }

        /// <summary>
        /// Unloads and removes a tab from existence. This will also dispose the UI browser object.
        /// </summary>
        /// <param name="tab">Tab to unregister</param>
        internal static void unregister(tab tab)
        {
            if (tabs.Contains(tab))
                tabs.Remove(tab);

            // Try dispose of the browser object
            try { tab.browserObject.Dispose(); } catch { }
        }

        /// <summary>
        /// Friendly call that closes all the objects related to a tab in memory. Will have to be removed 
        /// from the tabcontrol manually by the caller.
        /// </summary>
        /// <param name="identifier">Tab to close</param>
        /// <returns>Tab that was closed</returns>
        internal static tab close(string identifier)
        {
            foreach (tab x in tabs)
                if (x.identifier == identifier)
                {
                    x.browserObject.Dispose();
                    x.tabObject.Dispose();
                    unregister(x);
                    return x;
                }

            return new tab();
        }

        /// <summary>
        /// Sets the title of a tab
        /// </summary>
        /// <param name="identifier">Tab location identifier</param>
        /// <param name="newTitle">New title to replace old title</param>
        internal static void title(string identifier, string newTitle)
        {
            foreach (tab x in tabs)
                if (x.identifier == identifier)
                    x.tabObject.Text = newTitle;
        }

        /// <summary>
        /// Returns the title of a tab based on the in-memory identifier
        /// </summary>
        /// <param name="identifier">Tab location identifier</param>
        /// <returns>Title / name of the tab</returns>
        internal static string title(string identifier)
        {
            foreach (tab x in tabs)
                if (x.identifier == identifier)
                    return x.tabObject.Text;

            return "Unknown_Title";
        }

        /// <summary>
        /// Navigates to a new page in a specific tab
        /// </summary>
        /// <param name="identifier">Tab to renavigate</param>
        /// <param name="url">Web address to renavigate to</param>
        internal static void load(string identifier, string url)
        {
            foreach (tab x in tabs)
                if (x.identifier == identifier)
                {
                    x.browserObject.Load(url);
                    try { x.tabObject.Text = url.Substring(0, 15) + "..."; } catch { x.tabObject.Text = "Unknown name"; }
                }
        }
    }
}
