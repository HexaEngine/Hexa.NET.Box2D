// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;
using System.Numerics;

namespace Hexa.NET.Box2D
{
	/// <summary>
	/// Chain id references a chain instances. This should be treated as an opaque handle.<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "b2ChainId")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct B2ChainId
	{
		[NativeName(NativeNameType.Field, "index1")]
		[NativeName(NativeNameType.Type, "int32_t")]
		public int Index1;
		[NativeName(NativeNameType.Field, "world0")]
		[NativeName(NativeNameType.Type, "uint16_t")]
		public ushort World0;
		[NativeName(NativeNameType.Field, "revision")]
		[NativeName(NativeNameType.Type, "uint16_t")]
		public ushort Revision;

		public unsafe B2ChainId(int index1 = default, ushort world0 = default, ushort revision = default)
		{
			Index1 = index1;
			World0 = world0;
			Revision = revision;
		}


	}

}
