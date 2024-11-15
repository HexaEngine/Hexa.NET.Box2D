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
	/// Sensor events are buffered in the Box2D world and are available<br/>
	/// as begin/end overlap event arrays after the time step is complete.<br/>
	/// Note: these may become invalid if bodies and/or shapes are destroyed<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "b2SensorEvents")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct B2SensorEvents
	{
		/// <summary>
		/// Array of sensor begin touch events<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "beginEvents")]
		[NativeName(NativeNameType.Type, "b2SensorBeginTouchEvent *")]
		public unsafe B2SensorBeginTouchEvent* BeginEvents;

		/// <summary>
		/// Array of sensor end touch events<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "endEvents")]
		[NativeName(NativeNameType.Type, "b2SensorEndTouchEvent *")]
		public unsafe B2SensorEndTouchEvent* EndEvents;

		/// <summary>
		/// The number of begin touch events<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "beginCount")]
		[NativeName(NativeNameType.Type, "int32_t")]
		public int BeginCount;

		/// <summary>
		/// The number of end touch events<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "endCount")]
		[NativeName(NativeNameType.Type, "int32_t")]
		public int EndCount;


		public unsafe B2SensorEvents(B2SensorBeginTouchEvent* beginEvents = default, B2SensorEndTouchEvent* endEvents = default, int beginCount = default, int endCount = default)
		{
			BeginEvents = beginEvents;
			EndEvents = endEvents;
			BeginCount = beginCount;
			EndCount = endCount;
		}


	}

}
