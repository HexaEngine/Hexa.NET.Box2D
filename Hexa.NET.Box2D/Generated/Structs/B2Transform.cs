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
	/// A 2D rigid transform<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "b2Transform")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct B2Transform
	{
		[NativeName(NativeNameType.Field, "p")]
		[NativeName(NativeNameType.Type, "b2Vec2")]
		public Vector2 P;
		[NativeName(NativeNameType.Field, "q")]
		[NativeName(NativeNameType.Type, "b2Rot")]
		public B2Rot Q;

		public unsafe B2Transform(Vector2 p = default, B2Rot q = default)
		{
			P = p;
			Q = q;
		}


	}

}
