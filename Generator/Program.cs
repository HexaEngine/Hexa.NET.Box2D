using HexaGen;
using HexaGen.Patching;

BatchGenerator batch = new();
batch.Start()
    .Setup<CsCodeGenerator>("generator.json")
    .AddPrePatch(new NamingPatch(["B2"], NamingPatchOptions.None))
    .Generate([.. Directory.GetFiles("include")], "../../../../Hexa.NET.Box2D/Generated")
    .Finish();