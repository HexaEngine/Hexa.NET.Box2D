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
	/// The query filter is used to filter collisions between queries and shapes. For example,<br/>
	/// you may want a ray-cast representing a projectile to hit players and the static environment<br/>
	/// but not debris.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "b2QueryFilter")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct B2QueryFilter
	{
		/// <summary>
		/// The collision category bits of this query. Normally you would just set one bit.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "categoryBits")]
		[NativeName(NativeNameType.Type, "uint32_t")]
		public uint CategoryBits;

		/// <summary>
		/// The collision mask bits. This states the shape categories that this<br/>
		/// query would accept for collision.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "maskBits")]
		[NativeName(NativeNameType.Type, "uint32_t")]
		public uint MaskBits;


		public unsafe B2QueryFilter(uint categoryBits = default, uint maskBits = default)
		{
			CategoryBits = categoryBits;
			MaskBits = maskBits;
		}


	}

}
