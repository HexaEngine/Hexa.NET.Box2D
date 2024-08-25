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
	/// 2D rotation<br/>
	/// This is similar to using a complex number for rotation<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "b2Rot")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct B2Rot
	{
		/// <summary>
		/// cosine and sine<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "c")]
		[NativeName(NativeNameType.Type, "float")]
		public float C;

		/// <summary>
		/// cosine and sine<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "s")]
		[NativeName(NativeNameType.Type, "float")]
		public float S;


		public unsafe B2Rot(float c = default, float s = default)
		{
			C = c;
			S = s;
		}


	}

}
