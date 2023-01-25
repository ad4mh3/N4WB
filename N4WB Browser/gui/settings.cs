using N4WB_Browser.helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace N4WB_Browser.gui
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();

            /*
             * Apply theming
             */

            this.BackColor = theming.theme.MainBackColour;
            this.ForeColor = theming.theme.MainForeColour;

            /*
             * Import settings from registry
             */

            // Appearance
            if (registry.exists("AppearanceMode"))
                switch (registry.get("AppearanceMode"))
                {
                    case "0":
                        lightM.Checked = true;
                        break;
                    case "1":
                        darkM.Checked = true;
                        break;
                    case "2":
                        blackM.Checked = true;
                        break;
                }
            else
            {
                registry.set("AppearanceMode", "0");
                lightM.Checked = true;
            }

            // Javascript
            if (registry.exists("Javascript"))
                switch (registry.get("Javascript"))
                {
                    case "0":
                        javascriptT.Checked = false;
                        break;
                    case "1":
                        javascriptT.Checked = true;
                        break;
                }
            else
            {
                registry.set("Javascript", "0");
                javascriptT.Checked = false;
            }

            // Images
            if (registry.exists("Images"))
                switch (registry.get("Images"))
                {
                    case "0":
                        imagesT.Checked = false;    
                        break;
                    case "1":
                        imagesT.Checked = true;
                        break;
                }
            else
            {
                registry.set("Images", "0");
                imagesT.Checked = false;
            }

            // Auto-freezing of tabs
            if (registry.exists("TabAutoFreeze"))
                switch (registry.get("TabAutoFreeze"))
                {
                    case "0":
                        autofreezetabsT.Checked = false;
                        break;
                    case "1":
                        autofreezetabsT.Checked = true;
                        break;
                }
            else
            {
                registry.set("TabAutoFreeze", "0");
                autofreezetabsT.Checked = false;
            }

            // Compatible text rendering
            if (registry.exists("CompatibleTextRendering"))
                switch (registry.get("CompatibleTextRendering"))
                {
                    case "0":
                        compattextT.Checked = false;
                        break;
                    case "1":
                        compattextT.Checked = true;
                        break;
                }
            else
            {
                registry.set("CompatibleTextRendering", "0");
                compattextT.Checked = false;
            }

            // Tasks
            if (registry.exists("Tasks"))
                switch (registry.get("Tasks"))
                {
                    case "0":
                        tasksT.Checked = false;
                        break;
                    case "1":
                        tasksT.Checked = true;
                        break;
                }
            else
            {
                registry.set("Tasks", "0");
                tasksT.Checked = false;
            }

            // Useragent
            if (registry.exists("Useragent"))
                useragentTxt.Text = registry.get("Useragent");
            else
            {
                registry.set("Useragent", "");
                useragentTxt.Text = registry.get("Useragent");
            }
        }

        private void saveSettings_Click(object sender, EventArgs e)
        {
            /*
             * Save settings to registry
             */

            // Appearance
            if (registry.exists("AppearanceMode"))
                if(lightM.Checked)
                    registry.set("AppearanceMode", "0");
                else if (darkM.Checked)
                    registry.set("AppearanceMode", "1");
                else if (blackM.Checked)
                    registry.set("AppearanceMode", "2");

            // Javascript
            if (registry.exists("Javascript"))
                if (javascriptT.Checked)
                {
                    registry.set("Javascript", "1");

                    // Set javascript in all browsers currently open
                    foreach (tab x in helpers.tabControls.tabs)
                        if (x.browserObject.BrowserSettings.Javascript == CefSharp.CefState.Disabled)
                            x.browserObject.BrowserSettings.Javascript = CefSharp.CefState.Enabled;
                }
                else
                {
                    registry.set("Javascript", "0");

                    // Set javascript in all browsers currently open
                    foreach (tab x in helpers.tabControls.tabs)
                        if (x.browserObject.BrowserSettings.Javascript == CefSharp.CefState.Enabled)
                            x.browserObject.BrowserSettings.Javascript = CefSharp.CefState.Disabled;
                }

            // Images
            if (registry.exists("Images"))
                if (imagesT.Checked)
                    registry.set("Images", "1");
                else
                    registry.set("Images", "0");

            // Auto-freezing of tabs
            if (registry.exists("TabAutoFreeze"))
                if (imagesT.Checked)
                    registry.set("TabAutoFreeze", "1");
                else
                    registry.set("TabAutoFreeze", "0");

            // Compatible text rendering
            if (registry.exists("CompatibleTextRendering"))
                if (compattextT.Checked)
                    registry.set("CompatibleTextRendering", "1");
                else
                    registry.set("CompatibleTextRendering", "0");

            // Tasks
            if (registry.exists("Tasks"))
                if (tasksT.Checked)
                    registry.set("Tasks", "1");
                else
                    registry.set("Tasks", "0");

            // Useragent
            if (registry.exists("Useragent"))
                registry.set("Useragent", useragentTxt.Text);

            saveSettings.Enabled = false; // Disable save button
            N4WB_Browser.settings.load(); // Reload settings
        }

        private void exitWithoutSaving_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveThenExit_Click(object sender, EventArgs e)
        {
            saveSettings_Click(e, e);
            this.Close();
        }

        /// <summary>
        /// Re-enables the savesettings button if it is disabled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void javascriptT_CheckedChanged(object sender, EventArgs e)
        {
            saveSettings.Enabled = true;
        }

        /// <summary>
        /// Re-enables the savesettings button if it is disabled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lightM_CheckedChanged(object sender, EventArgs e)
        {
            saveSettings.Enabled = true;
        }

        /// <summary>
        /// Re-enables the savesettings button if it is disabled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void useragentTxt_TextChanged(object sender, EventArgs e)
        {
            saveSettings.Enabled = true;
        }

        private void settings_Load(object sender, EventArgs e)
        {
            // Set theme
            BackColor = theming.theme.MainBackColour;
            ForeColor = theming.theme.MainForeColour;

            mainContentContainer.BackColor = theming.theme.MainBackColour;
            mainContentContainer.ForeColor = theming.theme.MainForeColour;

            useragentContainer.BackColor = theming.theme.MainBackColour;
            useragentContainer.ForeColor = theming.theme.MainForeColour;

            pluginsContainer.BackColor = theming.theme.MainBackColour;
            pluginsContainer.ForeColor = theming.theme.MainForeColour;

            tasksContainer.BackColor = theming.theme.MainBackColour;
            tasksContainer.ForeColor = theming.theme.MainForeColour;

            appearanceContainer.BackColor = theming.theme.MainBackColour;
            appearanceContainer.ForeColor = theming.theme.MainForeColour;

            performanceContainer.BackColor = theming.theme.MainBackColour;
            performanceContainer.ForeColor = theming.theme.MainForeColour;
        }

        private void openTasksInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Tasks allow you to perform quick actions using specific buttons whilst being focused on the web address box.\n\nPressing the UP arrow will create a new tab and load the web address contents.\n\nMore tasks may be released in newer versions.");
        }
    }
}
