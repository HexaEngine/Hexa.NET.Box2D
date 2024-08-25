// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using HexaGen.Runtime;
using System.Numerics;

namespace Hexa.NET.Box2D
{
	/// <summary>
	/// The body simulation type.<br/>
	/// Each body is one of these three types. The type determines how the body behaves in the simulation.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "b2BodyType")]
	[Flags]
	public enum B2BodyType : int
	{
		/// <summary>
		/// zero mass, zero velocity, may be manually moved<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "b2_staticBody")]
		[NativeName(NativeNameType.Value, "0")]
		StaticBody = unchecked(0),

		/// <summary>
		/// zero mass, velocity set by user, moved by solver<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "b2_kinematicBody")]
		[NativeName(NativeNameType.Value, "1")]
		KinematicBody = unchecked(1),

		/// <summary>
		/// positive mass, velocity determined by forces, moved by solver<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "b2_dynamicBody")]
		[NativeName(NativeNameType.Value, "2")]
		DynamicBody = unchecked(2),

		/// <summary>
		/// number of body types<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "b2_bodyTypeCount")]
		[NativeName(NativeNameType.Value, "3")]
		Count = unchecked(3),
	}
}
