// SPDX-License-Identifier: MIT

using System.Collections.Generic;

namespace SDL2_dotnet
{
    public enum ScreenResolution
    {
        CGA, // 320x200
        EGA, // 640x350
        VGA, // 640x480
        SVGA, // 800x600
        XGA, // 1024x768
        WXGA, // 1280x800
        SXGA, // 1280x1024
        HD, // 1366x768
        HDPlus, // 1600x900
        FHD, // 1920x1080
        QHD, // 2560x1440
        UHD // 3840x2160
    }

    public static class ScreenResolutionExtensions
    {
        private static readonly Dictionary<ScreenResolution, (int width, int height)> _resolutions
            = new Dictionary<ScreenResolution, (int width, int height)>
            {
                { ScreenResolution.CGA, (320, 200) },
                { ScreenResolution.EGA, (640, 350) },
                { ScreenResolution.VGA, (640, 480) },
                { ScreenResolution.SVGA, (800, 600) },
                { ScreenResolution.XGA, (1024, 768) },
                { ScreenResolution.WXGA, (1280, 800) },
                { ScreenResolution.SXGA, (1280, 1024) },
                { ScreenResolution.HD, (1366, 768) },
                { ScreenResolution.HDPlus, (1600, 900) },
                { ScreenResolution.FHD, (1920, 1080) },
                { ScreenResolution.QHD, (2560, 1440) },
                { ScreenResolution.UHD, (3840, 2160) }
            };

        public static int Width(this ScreenResolution @this)
        {
            if (_resolutions.ContainsKey(@this))
            {
                return _resolutions[@this].width;
            }
            else
            {
                return 100;
            }
        }

        public static int Height(this ScreenResolution @this)
        {
            if (_resolutions.ContainsKey(@this))
            {
                return _resolutions[@this].height;
            }
            else
            {
                return 100;
            }
        }
    }
}
