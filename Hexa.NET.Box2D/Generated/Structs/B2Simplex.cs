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
	/// Simplex from the GJK algorithm<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "b2Simplex")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct B2Simplex
	{
		/// <summary>
		/// vertices<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "v1")]
		[NativeName(NativeNameType.Type, "b2SimplexVertex")]
		public B2SimplexVertex V1;

		/// <summary>
		/// vertices<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "v2")]
		[NativeName(NativeNameType.Type, "b2SimplexVertex")]
		public B2SimplexVertex V2;

		/// <summary>
		/// vertices<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "v3")]
		[NativeName(NativeNameType.Type, "b2SimplexVertex")]
		public B2SimplexVertex V3;

		/// <summary>
		/// number of valid vertices<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "count")]
		[NativeName(NativeNameType.Type, "int32_t")]
		public int Count;


		public unsafe B2Simplex(B2SimplexVertex v1 = default, B2SimplexVertex v2 = default, B2SimplexVertex v3 = default, int count = default)
		{
			V1 = v1;
			V2 = v2;
			V3 = v3;
			Count = count;
		}


	}

}
