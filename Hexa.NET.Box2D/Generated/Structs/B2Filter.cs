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
	/// This is used to filter collision on shapes. It affects shape-vs-shape collision<br/>
	/// and shape-versus-query collision (such as b2World_CastRay).<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "b2Filter")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct B2Filter
	{
		/// <summary>
		/// The collision category bits. Normally you would just set one bit. The category bits should<br/>
		/// represent your application object types. For example:<br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "categoryBits")]
		[NativeName(NativeNameType.Type, "uint32_t")]
		public uint CategoryBits;

		/// <summary>
		/// The collision mask bits. This states the categories that this<br/>
		/// shape would accept for collision.<br/>
		/// For example, you may want your player to only collide with static objects<br/>
		/// and other players.<br/>
		/// <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "maskBits")]
		[NativeName(NativeNameType.Type, "uint32_t")]
		public uint MaskBits;

		/// <summary>
		/// Collision groups allow a certain group of objects to never collide (negative)<br/>
		/// or always collide (positive). A group index of zero has no effect. Non-zero group filtering<br/>
		/// always wins against the mask bits.<br/>
		/// For example, you may want ragdolls to collide with other ragdolls but you don't want<br/>
		/// ragdoll self-collision. In this case you would give each ragdoll a unique negative group index<br/>
		/// and apply that group index to all shapes on the ragdoll.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "groupIndex")]
		[NativeName(NativeNameType.Type, "int32_t")]
		public int GroupIndex;


		public unsafe B2Filter(uint categoryBits = default, uint maskBits = default, int groupIndex = default)
		{
			CategoryBits = categoryBits;
			MaskBits = maskBits;
			GroupIndex = groupIndex;
		}


	}

}