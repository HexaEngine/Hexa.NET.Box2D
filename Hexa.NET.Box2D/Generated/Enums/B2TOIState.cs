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
	/// Describes the TOI output<br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "b2TOIState")]
	[Flags]
	public enum B2TOIState : int
	{
		[NativeName(NativeNameType.EnumItem, "b2_toiStateUnknown")]
		[NativeName(NativeNameType.Value, "0")]
		Unknown = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "b2_toiStateFailed")]
		[NativeName(NativeNameType.Value, "1")]
		Failed = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "b2_toiStateOverlapped")]
		[NativeName(NativeNameType.Value, "2")]
		Overlapped = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "b2_toiStateHit")]
		[NativeName(NativeNameType.Value, "3")]
		Hit = unchecked(3),
		[NativeName(NativeNameType.EnumItem, "b2_toiStateSeparated")]
		[NativeName(NativeNameType.Value, "4")]
		Separated = unchecked(4),
	}
}
