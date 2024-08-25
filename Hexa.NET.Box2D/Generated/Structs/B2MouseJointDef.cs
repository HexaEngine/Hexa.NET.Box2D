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
	/// A mouse joint is used to make a point on a body track a specified world point.<br/>
	/// This a soft constraint and allows the constraint to stretch without<br/>
	/// applying huge forces. This also applies rotation constraint heuristic to improve control.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "b2MouseJointDef")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct B2MouseJointDef
	{
		/// <summary>
		/// The first attached body.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "bodyIdA")]
		[NativeName(NativeNameType.Type, "b2BodyId")]
		public B2BodyId BodyIdA;

		/// <summary>
		/// The second attached body.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "bodyIdB")]
		[NativeName(NativeNameType.Type, "b2BodyId")]
		public B2BodyId BodyIdB;

		/// <summary>
		/// The initial target point in world space<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "target")]
		[NativeName(NativeNameType.Type, "b2Vec2")]
		public Vector2 Target;

		/// <summary>
		/// Stiffness in hertz<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "hertz")]
		[NativeName(NativeNameType.Type, "float")]
		public float Hertz;

		/// <summary>
		/// Damping ratio, non-dimensional<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "dampingRatio")]
		[NativeName(NativeNameType.Type, "float")]
		public float DampingRatio;

		/// <summary>
		/// Maximum force, typically in newtons<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "maxForce")]
		[NativeName(NativeNameType.Type, "float")]
		public float MaxForce;

		/// <summary>
		/// Set this flag to true if the attached bodies should collide.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "collideConnected")]
		[NativeName(NativeNameType.Type, "bool")]
		public byte CollideConnected;

		/// <summary>
		/// User data pointer<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "userData")]
		[NativeName(NativeNameType.Type, "void*")]
		public unsafe void* UserData;

		/// <summary>
		/// Used internally to detect a valid definition. DO NOT SET.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "internalValue")]
		[NativeName(NativeNameType.Type, "int32_t")]
		public int InternalValue;


		public unsafe B2MouseJointDef(B2BodyId bodyIdA = default, B2BodyId bodyIdB = default, Vector2 target = default, float hertz = default, float dampingRatio = default, float maxForce = default, bool collideConnected = default, void* userData = default, int internalValue = default)
		{
			BodyIdA = bodyIdA;
			BodyIdB = bodyIdB;
			Target = target;
			Hertz = hertz;
			DampingRatio = dampingRatio;
			MaxForce = maxForce;
			CollideConnected = collideConnected ? (byte)1 : (byte)0;
			UserData = userData;
			InternalValue = internalValue;
		}


	}

}
