namespace Hexa.NET.Box2D
{
    using System.Runtime.InteropServices;

    public static partial class Box2D
    {
        static Box2D()
        {
            InitApi();
        }

        public static string GetLibraryName()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return "box2d";
            }

            return "libbox2d";
        }
    }
}