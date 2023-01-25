using CefSharp;
using N4WB_Browser.gui;
using N4WB_Browser.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace N4WB_Browser.events
{
    public class LifeSpanHandler : ILifeSpanHandler
    {
        public bool DoClose(IWebBrowser browserControl, IBrowser browser)
        {
            return true;
        }

        public void OnAfterCreated(IWebBrowser browserControl, IBrowser browser)
        {
            return;
        }

        public void OnBeforeClose(IWebBrowser browserControl, IBrowser browser)
        {
            return;
        }

        /// <summary>
        /// This is here to prevent CefSharp creating a new window whenever a new window/tab is requested by the browser
        /// </summary>
        /// <param name="chromiumWebBrowser"></param>
        /// <param name="browser"></param>
        /// <param name="frame"></param>
        /// <param name="targetUrl"></param>
        /// <param name="targetFrameName"></param>
        /// <param name="targetDisposition"></param>
        /// <param name="userGesture"></param>
        /// <param name="popupFeatures"></param>
        /// <param name="windowInfo"></param>
        /// <param name="browserSettings"></param>
        /// <param name="noJavascriptAccess"></param>
        /// <param name="newBrowser"></param>
        /// <returns></returns>
        public bool OnBeforePopup(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, string targetUrl, string targetFrameName, WindowOpenDisposition targetDisposition, bool userGesture, IPopupFeatures popupFeatures, IWindowInfo windowInfo, IBrowserSettings browserSettings, ref bool noJavascriptAccess, out IWebBrowser newBrowser)
        {
            main.tabsAwaitingUIPlacement.Add(
                tabControls.make(targetUrl)
                );

            //browser.MainFrame.LoadUrl(targetUrl);
            newBrowser = null;
            return true;
        }
    }
}
