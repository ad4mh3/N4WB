# N4WB

> Aiming to build a better web browser for ReactOS

N4WB (Net4 WebBrowser) is an open source webbrowser that uses Chromium. It's built on .NET 4 so as to be compatible with ReactOS.

    Due to .NET 4.5 not being easily installed on ReactOS, N4WB uses an outdated and vulnerable Chromium version.

### Prerequisites

- **.NET 4 Runtime** (available through the ReactOS Application manager)
- **Microsoft Visual C++ 2013 Redistributable** (available through the ReactOS Application manager)



### Installation

1. Download the entirety of this project as a zip file (Code -> Download ZIP)
2. Extract to a new folder on your desktop
3. Run "N4WB Browser.exe"



### Compiling

1. Download the entirety of this project as a zip file (Code -> Download ZIP)
2. Extract to a new folder on your desktop
3. Open the .SLN file in Visual Studio (version 2022 is tested) and click start (this will compile to the bin->x86->debug folder)

> Please note: You will have to install cef.redist.x64.3.2623.1401, cef.redist.x86.3.2623.1401, CefSharp.Common.49.0.1, and CefSharp.WinForms.49.0.1 via the NUGET package manager.

### Copyright

N4WB uses Chromium: Copyright 2015 The Chromium Authors
N4WB uses CefSharp: Copyright © The CefSharp Authors. All rights reserved.



**The license for this project can be found in the LICENSE file. Please read it carefully and fully before continuing.**

Copyright @ Z4WB Authors. All rights reserved.
