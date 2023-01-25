using CefSharp.WinForms;
using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Diagnostics;
using N4WB_Browser.helpers;

namespace N4WB_Browser.gui
{
    public partial class main : Form
    {
        internal static List<tab> tabsAwaitingUIPlacement = new List<tab>();

        public main()
        {
            InitializeComponent();

            // Show warning to user
            warning warning = new warning();
            warning.ShowDialog();

            // Set cefsharp settings
            CefSettings browserSettings = new CefSettings();

            // Set useragent if one set
            if(N4WB_Browser.settings.Useragent != "")
                browserSettings.UserAgent = N4WB_Browser.settings.Useragent;

            // Init cefsharp
            Cef.Initialize(browserSettings);

            // Set theme
            BackColor = theming.theme.MainBackColour;
            ForeColor = theming.theme.MainForeColour;
        }

        private void newTab_Click(object sender, EventArgs e)
        {
            // Sanity check
            if (currentTabWebpageTxt.Text == string.Empty)
                currentTabWebpageTxt.Text = "https://www.google.com";

            // Call on helper to make new tab then import into ui
            tabUI.TabPages.Add(
                helpers.tabControls.make(currentTabWebpageTxt.Text).tabObject
                );

            // Set current tab as last in index order
            tabUI.SelectedIndex = tabUI.TabPages.Count - 1;
        }

        private void loadNew_Click(object sender, EventArgs e)
        {
            // Sanity check
            if (currentTabWebpageTxt.Text == string.Empty)
                currentTabWebpageTxt.Text = "https://www.google.com";

            // If no tabs exist, create new one instead
            if (tabUI.TabPages.Count == 0)
                newTab_Click(sender, e);
            else
                // Call on helper to change tab location
                helpers.tabControls.load(tabUI.SelectedTab.Name, currentTabWebpageTxt.Text);
        }

        private void invkCloseCurrent_Click(object sender, EventArgs e)
        {
            TabPage thisTab = tabUI.SelectedTab;
            tabUI.TabPages.Remove(thisTab);
            helpers.tabControls.close(thisTab.Name);
        }

        private void invkFreezeCurrent_Click(object sender, EventArgs e)
        {
            helpers.tabFreezing.freeze(tabUI.SelectedTab.Name);
        }

        private void invkUnfreezeCurrent_Click(object sender, EventArgs e)
        {
            helpers.tabFreezing.unfreeze(tabUI.SelectedTab.Name);
        }

        private void invkOpenNew_Click(object sender, EventArgs e)
        {
            // Call on helper to make new tab then import into ui
            tabUI.TabPages.Add(
                helpers.tabControls.make("about:blank").tabObject
                );

            // Set current tab as last in index order
            tabUI.SelectedIndex = tabUI.TabPages.Count - 1;
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabUI.TabPages.Count == 0)
                    return;

                tab thisTab = helpers.tabControls.find(tabUI.SelectedTab.Name);
                if (thisTab.browserObject.CanGoBack)
                    thisTab.browserObject.Back();
            }
            catch { }
        }

        private void goFrwd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabUI.TabPages.Count == 0)
                    return;

                tab thisTab = helpers.tabControls.find(tabUI.SelectedTab.Name);
                if (thisTab.browserObject.CanGoForward)
                    thisTab.browserObject.Forward();
            }
            catch { }
        }

        private void currentTabWebpageTxt_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:

                    // If no tabs exist, create new one instead
                    if (tabUI.TabPages.Count == 0)
                        newTab_Click(sender, e);
                    else
                        // Call on helper to change tab location
                        helpers.tabControls.load(tabUI.SelectedTab.Name, currentTabWebpageTxt.Text);

                    break;
                case Keys.Up:

                    // Ignore if tasks is disabled
                    if (!N4WB_Browser.settings.Tasks)
                        return;

                    // Call on helper to make new tab then import into ui
                    tab newTab = helpers.tabControls.make(currentTabWebpageTxt.Text);
                    tabUI.TabPages.Add(
                        newTab.tabObject
                        );

                    // Set webpage address in UI
                    currentTabWebpageTxt.Text = newTab.browserObject.Address;

                    // Set current tab as last in index order
                    tabUI.SelectedIndex = tabUI.TabPages.Count - 1;

                    break;
            }
        }

        private void main_Shown(object sender, EventArgs e)
        {
            // Set focus to web address UI
            currentTabWebpageTxt.Focus();
        }

        private void openSettings_Click(object sender, EventArgs e)
        {
            settings settingsFrm = new settings();
            settingsFrm.ShowDialog();
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void tabUI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(N4WB_Browser.settings.AutoFreezeTabs)
            {
                // Freeze all tabs except one being shown
                foreach (TabPage x in tabUI.TabPages)
                    if(x != tabUI.SelectedTab)
                        // Freeze tab as not currently open
                        tabFreezing.freeze(x.Name);
                    else
                        // Unfreeze current tab
                        tabFreezing.unfreeze(tabUI.SelectedTab.Name);
            }
        }

        private void newTabWorker_Tick(object sender, EventArgs e)
        {
            try
            {
                foreach (tab x in tabsAwaitingUIPlacement)
                {
                    // Call on helper to make new tab then import into ui
                    tabUI.TabPages.Add(
                        x.tabObject
                        );

                    // Set current tab as last in index order
                    tabUI.SelectedIndex = tabUI.TabPages.Count - 1;
                }

                tabsAwaitingUIPlacement.Clear();
            }
            catch { }
        }
    }
}
