using HexaGen.Runtime;

#if NET7_0_OR_GREATER
[assembly: System.Runtime.CompilerServices.DisableRuntimeMarshalling]
#endif

[assembly: NativeLibrary("box2d", TargetPlatform.Windows)]
[assembly: NativeLibrary("libbox2d", TargetPlatform.Linux)]
[assembly: NativeLibrary("libbox2d", TargetPlatform.Android)]
[assembly: NativeLibrary("libbox2d", TargetPlatform.OSX)]