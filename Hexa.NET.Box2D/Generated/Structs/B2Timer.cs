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
	/// <br/>
	/// Timer for profiling. This has platform specific code and may not work on every platform.<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "b2Timer")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct B2Timer
	{
		[NativeName(NativeNameType.Field, "start")]
		[NativeName(NativeNameType.Type, "int64_t")]
		public long Start;

		public unsafe B2Timer(long start = default)
		{
			Start = start;
		}


	}

}
