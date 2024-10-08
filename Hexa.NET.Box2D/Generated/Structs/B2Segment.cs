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
	/// A line segment with two-sided collision.<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "b2Segment")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct B2Segment
	{
		/// <summary>
		/// The first point<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "point1")]
		[NativeName(NativeNameType.Type, "b2Vec2")]
		public Vector2 Point1;

		/// <summary>
		/// The second point<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "point2")]
		[NativeName(NativeNameType.Type, "b2Vec2")]
		public Vector2 Point2;


		public unsafe B2Segment(Vector2 point1 = default, Vector2 point2 = default)
		{
			Point1 = point1;
			Point2 = point2;
		}


	}

}
