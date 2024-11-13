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
	/// Used to create a shape.<br/>
	/// This is a temporary object used to bundle shape creation parameters. You may use<br/>
	/// the same shape definition to create multiple shapes.<br/>
	/// Must be initialized using b2DefaultShapeDef().<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "b2ShapeDef")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct B2ShapeDef
	{
		/// <summary>
		/// Use this to store application specific shape data.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "userData")]
		[NativeName(NativeNameType.Type, "void *")]
		public unsafe void* UserData;

		/// <summary>
		/// The Coulomb (dry) friction coefficient, usually in the range [0,1].<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "friction")]
		[NativeName(NativeNameType.Type, "float")]
		public float Friction;

		/// <summary>
		/// The restitution (bounce) usually in the range [0,1].<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "restitution")]
		[NativeName(NativeNameType.Type, "float")]
		public float Restitution;

		/// <summary>
		/// The density, usually in kg/m^2.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "density")]
		[NativeName(NativeNameType.Type, "float")]
		public float Density;

		/// <summary>
		/// Collision filtering data.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "filter")]
		[NativeName(NativeNameType.Type, "b2Filter")]
		public B2Filter Filter;

		/// <summary>
		/// Custom debug draw color.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "customColor")]
		[NativeName(NativeNameType.Type, "uint32_t")]
		public uint CustomColor;

		/// <summary>
		/// A sensor shape generates overlap events but never generates a collision response.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "isSensor")]
		[NativeName(NativeNameType.Type, "bool")]
		public byte IsSensor;

		/// <summary>
		/// Enable sensor events for this shape. Only applies to kinematic and dynamic bodies. Ignored for sensors.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "enableSensorEvents")]
		[NativeName(NativeNameType.Type, "bool")]
		public byte EnableSensorEvents;

		/// <summary>
		/// Enable contact events for this shape. Only applies to kinematic and dynamic bodies. Ignored for sensors.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "enableContactEvents")]
		[NativeName(NativeNameType.Type, "bool")]
		public byte EnableContactEvents;

		/// <summary>
		/// Enable hit events for this shape. Only applies to kinematic and dynamic bodies. Ignored for sensors.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "enableHitEvents")]
		[NativeName(NativeNameType.Type, "bool")]
		public byte EnableHitEvents;

		/// <summary>
		/// Enable pre-solve contact events for this shape. Only applies to dynamic bodies. These are expensive<br/>
		/// and must be carefully handled due to threading. Ignored for sensors.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "enablePreSolveEvents")]
		[NativeName(NativeNameType.Type, "bool")]
		public byte EnablePreSolveEvents;

		/// <summary>
		/// Normally shapes on static bodies don't invoke contact creation when they are added to the world. This overrides<br/>
		/// that behavior and causes contact creation. This significantly slows down static body creation which can be important<br/>
		/// when there are many static shapes.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "forceContactCreation")]
		[NativeName(NativeNameType.Type, "bool")]
		public byte ForceContactCreation;

		/// <summary>
		/// Used internally to detect a valid definition. DO NOT SET.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "internalValue")]
		[NativeName(NativeNameType.Type, "int32_t")]
		public int InternalValue;


		public unsafe B2ShapeDef(void* userData = default, float friction = default, float restitution = default, float density = default, B2Filter filter = default, uint customColor = default, bool isSensor = default, bool enableSensorEvents = default, bool enableContactEvents = default, bool enableHitEvents = default, bool enablePreSolveEvents = default, bool forceContactCreation = default, int internalValue = default)
		{
			UserData = userData;
			Friction = friction;
			Restitution = restitution;
			Density = density;
			Filter = filter;
			CustomColor = customColor;
			IsSensor = isSensor ? (byte)1 : (byte)0;
			EnableSensorEvents = enableSensorEvents ? (byte)1 : (byte)0;
			EnableContactEvents = enableContactEvents ? (byte)1 : (byte)0;
			EnableHitEvents = enableHitEvents ? (byte)1 : (byte)0;
			EnablePreSolveEvents = enablePreSolveEvents ? (byte)1 : (byte)0;
			ForceContactCreation = forceContactCreation ? (byte)1 : (byte)0;
			InternalValue = internalValue;
		}


	}

}
