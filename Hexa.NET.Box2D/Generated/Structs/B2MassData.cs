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
	/// This holds the mass data computed for a shape.<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "b2MassData")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct B2MassData
	{
		/// <summary>
		/// The mass of the shape, usually in kilograms.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "mass")]
		[NativeName(NativeNameType.Type, "float")]
		public float Mass;

		/// <summary>
		/// The position of the shape's centroid relative to the shape's origin.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "center")]
		[NativeName(NativeNameType.Type, "b2Vec2")]
		public Vector2 Center;

		/// <summary>
		/// The rotational inertia of the shape about the local origin.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "rotationalInertia")]
		[NativeName(NativeNameType.Type, "float")]
		public float RotationalInertia;


		public unsafe B2MassData(float mass = default, Vector2 center = default, float rotationalInertia = default)
		{
			Mass = mass;
			Center = center;
			RotationalInertia = rotationalInertia;
		}


	}

}
