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
	/// Version numbering scheme.<br/>
	/// See https://semver.org/<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "b2Version")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct B2Version
	{
		/// <summary>
		/// Significant changes<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "major")]
		[NativeName(NativeNameType.Type, "int")]
		public int Major;

		/// <summary>
		/// Incremental changes<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "minor")]
		[NativeName(NativeNameType.Type, "int")]
		public int Minor;

		/// <summary>
		/// Bug fixes<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "revision")]
		[NativeName(NativeNameType.Type, "int")]
		public int Revision;


		public unsafe B2Version(int major = default, int minor = default, int revision = default)
		{
			Major = major;
			Minor = minor;
			Revision = revision;
		}


	}

}
