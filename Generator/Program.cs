using HexaGen;
using HexaGen.Patching;

CsCodeGeneratorConfig config = CsCodeGeneratorConfig.Load("generator.json");
CsCodeGenerator generator = new(config);
generator.PatchEngine.RegisterPrePatch(new NamingPatch(["B2"], NamingPatchOptions.None));
generator.Generate([.. Directory.GetFiles("include")], "../../../../Hexa.NET.Box2D/Generated");