// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using HexaGen.Runtime;
using System.Numerics;

namespace Hexa.NET.Box2D
{
	/// <summary>
	/// These colors are used for debug draw.<br/>
	/// See https://www.rapidtables.com/web/color/index.html<br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "b2HexColor")]
	[Flags]
	public enum B2HexColor : int
	{
		[NativeName(NativeNameType.EnumItem, "b2_colorAliceBlue")]
		[NativeName(NativeNameType.Value, "15792383")]
		AliceBlue = unchecked(15792383),
		[NativeName(NativeNameType.EnumItem, "b2_colorAntiqueWhite")]
		[NativeName(NativeNameType.Value, "16444375")]
		AntiqueWhite = unchecked(16444375),
		[NativeName(NativeNameType.EnumItem, "b2_colorAqua")]
		[NativeName(NativeNameType.Value, "65535")]
		Aqua = unchecked(65535),
		[NativeName(NativeNameType.EnumItem, "b2_colorAquamarine")]
		[NativeName(NativeNameType.Value, "8388564")]
		Aquamarine = unchecked(8388564),
		[NativeName(NativeNameType.EnumItem, "b2_colorAzure")]
		[NativeName(NativeNameType.Value, "15794175")]
		Azure = unchecked(15794175),
		[NativeName(NativeNameType.EnumItem, "b2_colorBeige")]
		[NativeName(NativeNameType.Value, "16119260")]
		Beige = unchecked(16119260),
		[NativeName(NativeNameType.EnumItem, "b2_colorBisque")]
		[NativeName(NativeNameType.Value, "16770244")]
		Bisque = unchecked(16770244),
		[NativeName(NativeNameType.EnumItem, "b2_colorBlack")]
		[NativeName(NativeNameType.Value, "0")]
		Black = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "b2_colorBlanchedAlmond")]
		[NativeName(NativeNameType.Value, "16772045")]
		BlanchedAlmond = unchecked(16772045),
		[NativeName(NativeNameType.EnumItem, "b2_colorBlue")]
		[NativeName(NativeNameType.Value, "255")]
		Blue = unchecked(255),
		[NativeName(NativeNameType.EnumItem, "b2_colorBlueViolet")]
		[NativeName(NativeNameType.Value, "9055202")]
		BlueViolet = unchecked(9055202),
		[NativeName(NativeNameType.EnumItem, "b2_colorBrown")]
		[NativeName(NativeNameType.Value, "10824234")]
		Brown = unchecked(10824234),
		[NativeName(NativeNameType.EnumItem, "b2_colorBurlywood")]
		[NativeName(NativeNameType.Value, "14596231")]
		Burlywood = unchecked(14596231),
		[NativeName(NativeNameType.EnumItem, "b2_colorCadetBlue")]
		[NativeName(NativeNameType.Value, "6266528")]
		CadetBlue = unchecked(6266528),
		[NativeName(NativeNameType.EnumItem, "b2_colorChartreuse")]
		[NativeName(NativeNameType.Value, "8388352")]
		Chartreuse = unchecked(8388352),
		[NativeName(NativeNameType.EnumItem, "b2_colorChocolate")]
		[NativeName(NativeNameType.Value, "13789470")]
		Chocolate = unchecked(13789470),
		[NativeName(NativeNameType.EnumItem, "b2_colorCoral")]
		[NativeName(NativeNameType.Value, "16744272")]
		Coral = unchecked(16744272),
		[NativeName(NativeNameType.EnumItem, "b2_colorCornflowerBlue")]
		[NativeName(NativeNameType.Value, "6591981")]
		CornflowerBlue = unchecked(6591981),
		[NativeName(NativeNameType.EnumItem, "b2_colorCornsilk")]
		[NativeName(NativeNameType.Value, "16775388")]
		Cornsilk = unchecked(16775388),
		[NativeName(NativeNameType.EnumItem, "b2_colorCrimson")]
		[NativeName(NativeNameType.Value, "14423100")]
		Crimson = unchecked(14423100),
		[NativeName(NativeNameType.EnumItem, "b2_colorCyan")]
		[NativeName(NativeNameType.Value, "65535")]
		Cyan = unchecked(65535),
		[NativeName(NativeNameType.EnumItem, "b2_colorDarkBlue")]
		[NativeName(NativeNameType.Value, "139")]
		DarkBlue = unchecked(139),
		[NativeName(NativeNameType.EnumItem, "b2_colorDarkCyan")]
		[NativeName(NativeNameType.Value, "35723")]
		DarkCyan = unchecked(35723),
		[NativeName(NativeNameType.EnumItem, "b2_colorDarkGoldenrod")]
		[NativeName(NativeNameType.Value, "12092939")]
		DarkGoldenrod = unchecked(12092939),
		[NativeName(NativeNameType.EnumItem, "b2_colorDarkGray")]
		[NativeName(NativeNameType.Value, "11119017")]
		DarkGray = unchecked(11119017),
		[NativeName(NativeNameType.EnumItem, "b2_colorDarkGreen")]
		[NativeName(NativeNameType.Value, "25600")]
		DarkGreen = unchecked(25600),
		[NativeName(NativeNameType.EnumItem, "b2_colorDarkKhaki")]
		[NativeName(NativeNameType.Value, "12433259")]
		DarkKhaki = unchecked(12433259),
		[NativeName(NativeNameType.EnumItem, "b2_colorDarkMagenta")]
		[NativeName(NativeNameType.Value, "9109643")]
		DarkMagenta = unchecked(9109643),
		[NativeName(NativeNameType.EnumItem, "b2_colorDarkOliveGreen")]
		[NativeName(NativeNameType.Value, "5597999")]
		DarkOliveGreen = unchecked(5597999),
		[NativeName(NativeNameType.EnumItem, "b2_colorDarkOrange")]
		[NativeName(NativeNameType.Value, "16747520")]
		DarkOrange = unchecked(16747520),
		[NativeName(NativeNameType.EnumItem, "b2_colorDarkOrchid")]
		[NativeName(NativeNameType.Value, "10040012")]
		DarkOrchid = unchecked(10040012),
		[NativeName(NativeNameType.EnumItem, "b2_colorDarkRed")]
		[NativeName(NativeNameType.Value, "9109504")]
		DarkRed = unchecked(9109504),
		[NativeName(NativeNameType.EnumItem, "b2_colorDarkSalmon")]
		[NativeName(NativeNameType.Value, "15308410")]
		DarkSalmon = unchecked(15308410),
		[NativeName(NativeNameType.EnumItem, "b2_colorDarkSeaGreen")]
		[NativeName(NativeNameType.Value, "9419919")]
		DarkSeaGreen = unchecked(9419919),
		[NativeName(NativeNameType.EnumItem, "b2_colorDarkSlateBlue")]
		[NativeName(NativeNameType.Value, "4734347")]
		DarkSlateBlue = unchecked(4734347),
		[NativeName(NativeNameType.EnumItem, "b2_colorDarkSlateGray")]
		[NativeName(NativeNameType.Value, "3100495")]
		DarkSlateGray = unchecked(3100495),
		[NativeName(NativeNameType.EnumItem, "b2_colorDarkTurquoise")]
		[NativeName(NativeNameType.Value, "52945")]
		DarkTurquoise = unchecked(52945),
		[NativeName(NativeNameType.EnumItem, "b2_colorDarkViolet")]
		[NativeName(NativeNameType.Value, "9699539")]
		DarkViolet = unchecked(9699539),
		[NativeName(NativeNameType.EnumItem, "b2_colorDeepPink")]
		[NativeName(NativeNameType.Value, "16716947")]
		DeepPink = unchecked(16716947),
		[NativeName(NativeNameType.EnumItem, "b2_colorDeepSkyBlue")]
		[NativeName(NativeNameType.Value, "49151")]
		DeepSkyBlue = unchecked(49151),
		[NativeName(NativeNameType.EnumItem, "b2_colorDimGray")]
		[NativeName(NativeNameType.Value, "6908265")]
		DimGray = unchecked(6908265),
		[NativeName(NativeNameType.EnumItem, "b2_colorDodgerBlue")]
		[NativeName(NativeNameType.Value, "2003199")]
		DodgerBlue = unchecked(2003199),
		[NativeName(NativeNameType.EnumItem, "b2_colorFirebrick")]
		[NativeName(NativeNameType.Value, "11674146")]
		Firebrick = unchecked(11674146),
		[NativeName(NativeNameType.EnumItem, "b2_colorFloralWhite")]
		[NativeName(NativeNameType.Value, "16775920")]
		FloralWhite = unchecked(16775920),
		[NativeName(NativeNameType.EnumItem, "b2_colorForestGreen")]
		[NativeName(NativeNameType.Value, "2263842")]
		ForestGreen = unchecked(2263842),
		[NativeName(NativeNameType.EnumItem, "b2_colorFuchsia")]
		[NativeName(NativeNameType.Value, "16711935")]
		Fuchsia = unchecked(16711935),
		[NativeName(NativeNameType.EnumItem, "b2_colorGainsboro")]
		[NativeName(NativeNameType.Value, "14474460")]
		Gainsboro = unchecked(14474460),
		[NativeName(NativeNameType.EnumItem, "b2_colorGhostWhite")]
		[NativeName(NativeNameType.Value, "16316671")]
		GhostWhite = unchecked(16316671),
		[NativeName(NativeNameType.EnumItem, "b2_colorGold")]
		[NativeName(NativeNameType.Value, "16766720")]
		Gold = unchecked(16766720),
		[NativeName(NativeNameType.EnumItem, "b2_colorGoldenrod")]
		[NativeName(NativeNameType.Value, "14329120")]
		Goldenrod = unchecked(14329120),
		[NativeName(NativeNameType.EnumItem, "b2_colorGray")]
		[NativeName(NativeNameType.Value, "12500670")]
		Gray = unchecked(12500670),
		[NativeName(NativeNameType.EnumItem, "b2_colorGray1")]
		[NativeName(NativeNameType.Value, "1710618")]
		Gray1 = unchecked(1710618),
		[NativeName(NativeNameType.EnumItem, "b2_colorGray2")]
		[NativeName(NativeNameType.Value, "3355443")]
		Gray2 = unchecked(3355443),
		[NativeName(NativeNameType.EnumItem, "b2_colorGray3")]
		[NativeName(NativeNameType.Value, "5066061")]
		Gray3 = unchecked(5066061),
		[NativeName(NativeNameType.EnumItem, "b2_colorGray4")]
		[NativeName(NativeNameType.Value, "6710886")]
		Gray4 = unchecked(6710886),
		[NativeName(NativeNameType.EnumItem, "b2_colorGray5")]
		[NativeName(NativeNameType.Value, "8355711")]
		Gray5 = unchecked(8355711),
		[NativeName(NativeNameType.EnumItem, "b2_colorGray6")]
		[NativeName(NativeNameType.Value, "10066329")]
		Gray6 = unchecked(10066329),
		[NativeName(NativeNameType.EnumItem, "b2_colorGray7")]
		[NativeName(NativeNameType.Value, "11776947")]
		Gray7 = unchecked(11776947),
		[NativeName(NativeNameType.EnumItem, "b2_colorGray8")]
		[NativeName(NativeNameType.Value, "13421772")]
		Gray8 = unchecked(13421772),
		[NativeName(NativeNameType.EnumItem, "b2_colorGray9")]
		[NativeName(NativeNameType.Value, "15066597")]
		Gray9 = unchecked(15066597),
		[NativeName(NativeNameType.EnumItem, "b2_colorGreen")]
		[NativeName(NativeNameType.Value, "65280")]
		Green = unchecked(65280),
		[NativeName(NativeNameType.EnumItem, "b2_colorGreenYellow")]
		[NativeName(NativeNameType.Value, "11403055")]
		GreenYellow = unchecked(11403055),
		[NativeName(NativeNameType.EnumItem, "b2_colorHoneydew")]
		[NativeName(NativeNameType.Value, "15794160")]
		Honeydew = unchecked(15794160),
		[NativeName(NativeNameType.EnumItem, "b2_colorHotPink")]
		[NativeName(NativeNameType.Value, "16738740")]
		HotPink = unchecked(16738740),
		[NativeName(NativeNameType.EnumItem, "b2_colorIndianRed")]
		[NativeName(NativeNameType.Value, "13458524")]
		IndianRed = unchecked(13458524),
		[NativeName(NativeNameType.EnumItem, "b2_colorIndigo")]
		[NativeName(NativeNameType.Value, "4915330")]
		Indigo = unchecked(4915330),
		[NativeName(NativeNameType.EnumItem, "b2_colorIvory")]
		[NativeName(NativeNameType.Value, "16777200")]
		Ivory = unchecked(16777200),
		[NativeName(NativeNameType.EnumItem, "b2_colorKhaki")]
		[NativeName(NativeNameType.Value, "15787660")]
		Khaki = unchecked(15787660),
		[NativeName(NativeNameType.EnumItem, "b2_colorLavender")]
		[NativeName(NativeNameType.Value, "15132410")]
		Lavender = unchecked(15132410),
		[NativeName(NativeNameType.EnumItem, "b2_colorLavenderBlush")]
		[NativeName(NativeNameType.Value, "16773365")]
		LavenderBlush = unchecked(16773365),
		[NativeName(NativeNameType.EnumItem, "b2_colorLawnGreen")]
		[NativeName(NativeNameType.Value, "8190976")]
		LawnGreen = unchecked(8190976),
		[NativeName(NativeNameType.EnumItem, "b2_colorLemonChiffon")]
		[NativeName(NativeNameType.Value, "16775885")]
		LemonChiffon = unchecked(16775885),
		[NativeName(NativeNameType.EnumItem, "b2_colorLightBlue")]
		[NativeName(NativeNameType.Value, "11393254")]
		LightBlue = unchecked(11393254),
		[NativeName(NativeNameType.EnumItem, "b2_colorLightCoral")]
		[NativeName(NativeNameType.Value, "15761536")]
		LightCoral = unchecked(15761536),
		[NativeName(NativeNameType.EnumItem, "b2_colorLightCyan")]
		[NativeName(NativeNameType.Value, "14745599")]
		LightCyan = unchecked(14745599),
		[NativeName(NativeNameType.EnumItem, "b2_colorLightGoldenrod")]
		[NativeName(NativeNameType.Value, "15654274")]
		LightGoldenrod = unchecked(15654274),
		[NativeName(NativeNameType.EnumItem, "b2_colorLightGoldenrodYellow")]
		[NativeName(NativeNameType.Value, "16448210")]
		LightGoldenrodYellow = unchecked(16448210),
		[NativeName(NativeNameType.EnumItem, "b2_colorLightGray")]
		[NativeName(NativeNameType.Value, "13882323")]
		LightGray = unchecked(13882323),
		[NativeName(NativeNameType.EnumItem, "b2_colorLightGreen")]
		[NativeName(NativeNameType.Value, "9498256")]
		LightGreen = unchecked(9498256),
		[NativeName(NativeNameType.EnumItem, "b2_colorLightPink")]
		[NativeName(NativeNameType.Value, "16758465")]
		LightPink = unchecked(16758465),
		[NativeName(NativeNameType.EnumItem, "b2_colorLightSalmon")]
		[NativeName(NativeNameType.Value, "16752762")]
		LightSalmon = unchecked(16752762),
		[NativeName(NativeNameType.EnumItem, "b2_colorLightSeaGreen")]
		[NativeName(NativeNameType.Value, "2142890")]
		LightSeaGreen = unchecked(2142890),
		[NativeName(NativeNameType.EnumItem, "b2_colorLightSkyBlue")]
		[NativeName(NativeNameType.Value, "8900346")]
		LightSkyBlue = unchecked(8900346),
		[NativeName(NativeNameType.EnumItem, "b2_colorLightSlateBlue")]
		[NativeName(NativeNameType.Value, "8679679")]
		LightSlateBlue = unchecked(8679679),
		[NativeName(NativeNameType.EnumItem, "b2_colorLightSlateGray")]
		[NativeName(NativeNameType.Value, "7833753")]
		LightSlateGray = unchecked(7833753),
		[NativeName(NativeNameType.EnumItem, "b2_colorLightSteelBlue")]
		[NativeName(NativeNameType.Value, "11584734")]
		LightSteelBlue = unchecked(11584734),
		[NativeName(NativeNameType.EnumItem, "b2_colorLightYellow")]
		[NativeName(NativeNameType.Value, "16777184")]
		LightYellow = unchecked(16777184),
		[NativeName(NativeNameType.EnumItem, "b2_colorLime")]
		[NativeName(NativeNameType.Value, "65280")]
		Lime = unchecked(65280),
		[NativeName(NativeNameType.EnumItem, "b2_colorLimeGreen")]
		[NativeName(NativeNameType.Value, "3329330")]
		LimeGreen = unchecked(3329330),
		[NativeName(NativeNameType.EnumItem, "b2_colorLinen")]
		[NativeName(NativeNameType.Value, "16445670")]
		Linen = unchecked(16445670),
		[NativeName(NativeNameType.EnumItem, "b2_colorMagenta")]
		[NativeName(NativeNameType.Value, "16711935")]
		Magenta = unchecked(16711935),
		[NativeName(NativeNameType.EnumItem, "b2_colorMaroon")]
		[NativeName(NativeNameType.Value, "11546720")]
		Maroon = unchecked(11546720),
		[NativeName(NativeNameType.EnumItem, "b2_colorMediumAquamarine")]
		[NativeName(NativeNameType.Value, "6737322")]
		MediumAquamarine = unchecked(6737322),
		[NativeName(NativeNameType.EnumItem, "b2_colorMediumBlue")]
		[NativeName(NativeNameType.Value, "205")]
		MediumBlue = unchecked(205),
		[NativeName(NativeNameType.EnumItem, "b2_colorMediumOrchid")]
		[NativeName(NativeNameType.Value, "12211667")]
		MediumOrchid = unchecked(12211667),
		[NativeName(NativeNameType.EnumItem, "b2_colorMediumPurple")]
		[NativeName(NativeNameType.Value, "9662683")]
		MediumPurple = unchecked(9662683),
		[NativeName(NativeNameType.EnumItem, "b2_colorMediumSeaGreen")]
		[NativeName(NativeNameType.Value, "3978097")]
		MediumSeaGreen = unchecked(3978097),
		[NativeName(NativeNameType.EnumItem, "b2_colorMediumSlateBlue")]
		[NativeName(NativeNameType.Value, "8087790")]
		MediumSlateBlue = unchecked(8087790),
		[NativeName(NativeNameType.EnumItem, "b2_colorMediumSpringGreen")]
		[NativeName(NativeNameType.Value, "64154")]
		MediumSpringGreen = unchecked(64154),
		[NativeName(NativeNameType.EnumItem, "b2_colorMediumTurquoise")]
		[NativeName(NativeNameType.Value, "4772300")]
		MediumTurquoise = unchecked(4772300),
		[NativeName(NativeNameType.EnumItem, "b2_colorMediumVioletRed")]
		[NativeName(NativeNameType.Value, "13047173")]
		MediumVioletRed = unchecked(13047173),
		[NativeName(NativeNameType.EnumItem, "b2_colorMidnightBlue")]
		[NativeName(NativeNameType.Value, "1644912")]
		MidnightBlue = unchecked(1644912),
		[NativeName(NativeNameType.EnumItem, "b2_colorMintCream")]
		[NativeName(NativeNameType.Value, "16121850")]
		MintCream = unchecked(16121850),
		[NativeName(NativeNameType.EnumItem, "b2_colorMistyRose")]
		[NativeName(NativeNameType.Value, "16770273")]
		MistyRose = unchecked(16770273),
		[NativeName(NativeNameType.EnumItem, "b2_colorMoccasin")]
		[NativeName(NativeNameType.Value, "16770229")]
		Moccasin = unchecked(16770229),
		[NativeName(NativeNameType.EnumItem, "b2_colorNavajoWhite")]
		[NativeName(NativeNameType.Value, "16768685")]
		NavajoWhite = unchecked(16768685),
		[NativeName(NativeNameType.EnumItem, "b2_colorNavy")]
		[NativeName(NativeNameType.Value, "128")]
		Navy = unchecked(128),
		[NativeName(NativeNameType.EnumItem, "b2_colorNavyBlue")]
		[NativeName(NativeNameType.Value, "128")]
		NavyBlue = unchecked(128),
		[NativeName(NativeNameType.EnumItem, "b2_colorOldLace")]
		[NativeName(NativeNameType.Value, "16643558")]
		OldLace = unchecked(16643558),
		[NativeName(NativeNameType.EnumItem, "b2_colorOlive")]
		[NativeName(NativeNameType.Value, "8421376")]
		Olive = unchecked(8421376),
		[NativeName(NativeNameType.EnumItem, "b2_colorOliveDrab")]
		[NativeName(NativeNameType.Value, "7048739")]
		OliveDrab = unchecked(7048739),
		[NativeName(NativeNameType.EnumItem, "b2_colorOrange")]
		[NativeName(NativeNameType.Value, "16753920")]
		Orange = unchecked(16753920),
		[NativeName(NativeNameType.EnumItem, "b2_colorOrangeRed")]
		[NativeName(NativeNameType.Value, "16729344")]
		OrangeRed = unchecked(16729344),
		[NativeName(NativeNameType.EnumItem, "b2_colorOrchid")]
		[NativeName(NativeNameType.Value, "14315734")]
		Orchid = unchecked(14315734),
		[NativeName(NativeNameType.EnumItem, "b2_colorPaleGoldenrod")]
		[NativeName(NativeNameType.Value, "15657130")]
		PaleGoldenrod = unchecked(15657130),
		[NativeName(NativeNameType.EnumItem, "b2_colorPaleGreen")]
		[NativeName(NativeNameType.Value, "10025880")]
		PaleGreen = unchecked(10025880),
		[NativeName(NativeNameType.EnumItem, "b2_colorPaleTurquoise")]
		[NativeName(NativeNameType.Value, "11529966")]
		PaleTurquoise = unchecked(11529966),
		[NativeName(NativeNameType.EnumItem, "b2_colorPaleVioletRed")]
		[NativeName(NativeNameType.Value, "14381203")]
		PaleVioletRed = unchecked(14381203),
		[NativeName(NativeNameType.EnumItem, "b2_colorPapayaWhip")]
		[NativeName(NativeNameType.Value, "16773077")]
		PapayaWhip = unchecked(16773077),
		[NativeName(NativeNameType.EnumItem, "b2_colorPeachPuff")]
		[NativeName(NativeNameType.Value, "16767673")]
		PeachPuff = unchecked(16767673),
		[NativeName(NativeNameType.EnumItem, "b2_colorPeru")]
		[NativeName(NativeNameType.Value, "13468991")]
		Peru = unchecked(13468991),
		[NativeName(NativeNameType.EnumItem, "b2_colorPink")]
		[NativeName(NativeNameType.Value, "16761035")]
		Pink = unchecked(16761035),
		[NativeName(NativeNameType.EnumItem, "b2_colorPlum")]
		[NativeName(NativeNameType.Value, "14524637")]
		Plum = unchecked(14524637),
		[NativeName(NativeNameType.EnumItem, "b2_colorPowderBlue")]
		[NativeName(NativeNameType.Value, "11591910")]
		PowderBlue = unchecked(11591910),
		[NativeName(NativeNameType.EnumItem, "b2_colorPurple")]
		[NativeName(NativeNameType.Value, "10494192")]
		Purple = unchecked(10494192),
		[NativeName(NativeNameType.EnumItem, "b2_colorRebeccaPurple")]
		[NativeName(NativeNameType.Value, "6697881")]
		RebeccaPurple = unchecked(6697881),
		[NativeName(NativeNameType.EnumItem, "b2_colorRed")]
		[NativeName(NativeNameType.Value, "16711680")]
		Red = unchecked(16711680),
		[NativeName(NativeNameType.EnumItem, "b2_colorRosyBrown")]
		[NativeName(NativeNameType.Value, "12357519")]
		RosyBrown = unchecked(12357519),
		[NativeName(NativeNameType.EnumItem, "b2_colorRoyalBlue")]
		[NativeName(NativeNameType.Value, "4286945")]
		RoyalBlue = unchecked(4286945),
		[NativeName(NativeNameType.EnumItem, "b2_colorSaddleBrown")]
		[NativeName(NativeNameType.Value, "9127187")]
		SaddleBrown = unchecked(9127187),
		[NativeName(NativeNameType.EnumItem, "b2_colorSalmon")]
		[NativeName(NativeNameType.Value, "16416882")]
		Salmon = unchecked(16416882),
		[NativeName(NativeNameType.EnumItem, "b2_colorSandyBrown")]
		[NativeName(NativeNameType.Value, "16032864")]
		SandyBrown = unchecked(16032864),
		[NativeName(NativeNameType.EnumItem, "b2_colorSeaGreen")]
		[NativeName(NativeNameType.Value, "3050327")]
		SeaGreen = unchecked(3050327),
		[NativeName(NativeNameType.EnumItem, "b2_colorSeashell")]
		[NativeName(NativeNameType.Value, "16774638")]
		Seashell = unchecked(16774638),
		[NativeName(NativeNameType.EnumItem, "b2_colorSienna")]
		[NativeName(NativeNameType.Value, "10506797")]
		Sienna = unchecked(10506797),
		[NativeName(NativeNameType.EnumItem, "b2_colorSilver")]
		[NativeName(NativeNameType.Value, "12632256")]
		Silver = unchecked(12632256),
		[NativeName(NativeNameType.EnumItem, "b2_colorSkyBlue")]
		[NativeName(NativeNameType.Value, "8900331")]
		SkyBlue = unchecked(8900331),
		[NativeName(NativeNameType.EnumItem, "b2_colorSlateBlue")]
		[NativeName(NativeNameType.Value, "6970061")]
		SlateBlue = unchecked(6970061),
		[NativeName(NativeNameType.EnumItem, "b2_colorSlateGray")]
		[NativeName(NativeNameType.Value, "7372944")]
		SlateGray = unchecked(7372944),
		[NativeName(NativeNameType.EnumItem, "b2_colorSnow")]
		[NativeName(NativeNameType.Value, "16775930")]
		Snow = unchecked(16775930),
		[NativeName(NativeNameType.EnumItem, "b2_colorSpringGreen")]
		[NativeName(NativeNameType.Value, "65407")]
		SpringGreen = unchecked(65407),
		[NativeName(NativeNameType.EnumItem, "b2_colorSteelBlue")]
		[NativeName(NativeNameType.Value, "4620980")]
		SteelBlue = unchecked(4620980),
		[NativeName(NativeNameType.EnumItem, "b2_colorTan")]
		[NativeName(NativeNameType.Value, "13808780")]
		Tan = unchecked(13808780),
		[NativeName(NativeNameType.EnumItem, "b2_colorTeal")]
		[NativeName(NativeNameType.Value, "32896")]
		Teal = unchecked(32896),
		[NativeName(NativeNameType.EnumItem, "b2_colorThistle")]
		[NativeName(NativeNameType.Value, "14204888")]
		Thistle = unchecked(14204888),
		[NativeName(NativeNameType.EnumItem, "b2_colorTomato")]
		[NativeName(NativeNameType.Value, "16737095")]
		Tomato = unchecked(16737095),
		[NativeName(NativeNameType.EnumItem, "b2_colorTurquoise")]
		[NativeName(NativeNameType.Value, "4251856")]
		Turquoise = unchecked(4251856),
		[NativeName(NativeNameType.EnumItem, "b2_colorViolet")]
		[NativeName(NativeNameType.Value, "15631086")]
		Violet = unchecked(15631086),
		[NativeName(NativeNameType.EnumItem, "b2_colorVioletRed")]
		[NativeName(NativeNameType.Value, "13639824")]
		VioletRed = unchecked(13639824),
		[NativeName(NativeNameType.EnumItem, "b2_colorWheat")]
		[NativeName(NativeNameType.Value, "16113331")]
		Wheat = unchecked(16113331),
		[NativeName(NativeNameType.EnumItem, "b2_colorWhite")]
		[NativeName(NativeNameType.Value, "16777215")]
		White = unchecked(16777215),
		[NativeName(NativeNameType.EnumItem, "b2_colorWhiteSmoke")]
		[NativeName(NativeNameType.Value, "16119285")]
		WhiteSmoke = unchecked(16119285),
		[NativeName(NativeNameType.EnumItem, "b2_colorYellow")]
		[NativeName(NativeNameType.Value, "16776960")]
		Yellow = unchecked(16776960),
		[NativeName(NativeNameType.EnumItem, "b2_colorYellowGreen")]
		[NativeName(NativeNameType.Value, "10145074")]
		YellowGreen = unchecked(10145074),
		[NativeName(NativeNameType.EnumItem, "b2_colorBox2DRed")]
		[NativeName(NativeNameType.Value, "14430514")]
		Box2DRed = unchecked(14430514),
		[NativeName(NativeNameType.EnumItem, "b2_colorBox2DBlue")]
		[NativeName(NativeNameType.Value, "3190463")]
		Box2DBlue = unchecked(3190463),
		[NativeName(NativeNameType.EnumItem, "b2_colorBox2DGreen")]
		[NativeName(NativeNameType.Value, "9226532")]
		Box2DGreen = unchecked(9226532),
		[NativeName(NativeNameType.EnumItem, "b2_colorBox2DYellow")]
		[NativeName(NativeNameType.Value, "16772748")]
		Box2DYellow = unchecked(16772748),
	}
}