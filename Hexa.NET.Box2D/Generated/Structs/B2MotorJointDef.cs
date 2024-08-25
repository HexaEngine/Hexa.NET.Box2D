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
	/// A motor joint is used to control the relative motion between two bodies<br/>
	/// A typical usage is to control the movement of a dynamic body with respect to the ground.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "b2MotorJointDef")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct B2MotorJointDef
	{
		/// <summary>
		/// The first attached body<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "bodyIdA")]
		[NativeName(NativeNameType.Type, "b2BodyId")]
		public B2BodyId BodyIdA;

		/// <summary>
		/// The second attached body<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "bodyIdB")]
		[NativeName(NativeNameType.Type, "b2BodyId")]
		public B2BodyId BodyIdB;

		/// <summary>
		/// Position of bodyB minus the position of bodyA, in bodyA's frame<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "linearOffset")]
		[NativeName(NativeNameType.Type, "b2Vec2")]
		public Vector2 LinearOffset;

		/// <summary>
		/// The bodyB angle minus bodyA angle in radians<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "angularOffset")]
		[NativeName(NativeNameType.Type, "float")]
		public float AngularOffset;

		/// <summary>
		/// The maximum motor force in newtons<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "maxForce")]
		[NativeName(NativeNameType.Type, "float")]
		public float MaxForce;

		/// <summary>
		/// The maximum motor torque in newton-meters<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "maxTorque")]
		[NativeName(NativeNameType.Type, "float")]
		public float MaxTorque;

		/// <summary>
		/// Position correction factor in the range [0,1]<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "correctionFactor")]
		[NativeName(NativeNameType.Type, "float")]
		public float CorrectionFactor;

		/// <summary>
		/// Set this flag to true if the attached bodies should collide<br/>
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


		public unsafe B2MotorJointDef(B2BodyId bodyIdA = default, B2BodyId bodyIdB = default, Vector2 linearOffset = default, float angularOffset = default, float maxForce = default, float maxTorque = default, float correctionFactor = default, bool collideConnected = default, void* userData = default, int internalValue = default)
		{
			BodyIdA = bodyIdA;
			BodyIdB = bodyIdB;
			LinearOffset = linearOffset;
			AngularOffset = angularOffset;
			MaxForce = maxForce;
			MaxTorque = maxTorque;
			CorrectionFactor = correctionFactor;
			CollideConnected = collideConnected ? (byte)1 : (byte)0;
			UserData = userData;
			InternalValue = internalValue;
		}


	}

}