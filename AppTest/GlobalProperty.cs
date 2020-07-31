using System;

namespace AppTest
{
    static class GlobalProperty
    {
        static public bool isEasyScreenShot = false;
        static public string ScreenShotName
        {
            get
            {
                return "ScreenShot" + DateTime.Now.ToString("F") + ".jpeg";
            }
        }
        static public string savedFolder = @"C:\Users\Public\Pictures\IScreens";
    }
}
