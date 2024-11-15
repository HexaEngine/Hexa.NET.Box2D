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
	/// Body events are buffered in the Box2D world and are available<br/>
	/// as event arrays after the time step is complete.<br/>
	/// Note: this data becomes invalid if bodies are destroyed<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "b2BodyEvents")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct B2BodyEvents
	{
		/// <summary>
		/// Array of move events<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "moveEvents")]
		[NativeName(NativeNameType.Type, "b2BodyMoveEvent *")]
		public unsafe B2BodyMoveEvent* MoveEvents;

		/// <summary>
		/// Number of move events<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "moveCount")]
		[NativeName(NativeNameType.Type, "int32_t")]
		public int MoveCount;


		public unsafe B2BodyEvents(B2BodyMoveEvent* moveEvents = default, int moveCount = default)
		{
			MoveEvents = moveEvents;
			MoveCount = moveCount;
		}


	}

}
