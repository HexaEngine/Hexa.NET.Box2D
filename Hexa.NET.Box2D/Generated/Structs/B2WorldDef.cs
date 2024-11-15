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
	/// World definition used to create a simulation world.<br/>
	/// Must be initialized using b2DefaultWorldDef().<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "b2WorldDef")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct B2WorldDef
	{
		/// <summary>
		/// Gravity vector. Box2D has no up-vector defined.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "gravity")]
		[NativeName(NativeNameType.Type, "b2Vec2")]
		public Vector2 Gravity;

		/// <summary>
		/// Restitution velocity threshold, usually in m/s. Collisions above this<br/>
		/// speed have restitution applied (will bounce).<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "restitutionThreshold")]
		[NativeName(NativeNameType.Type, "float")]
		public float RestitutionThreshold;

		/// <summary>
		/// This parameter controls how fast overlap is resolved and has units of meters per second<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "contactPushoutVelocity")]
		[NativeName(NativeNameType.Type, "float")]
		public float ContactPushoutVelocity;

		/// <summary>
		/// Threshold velocity for hit events. Usually meters per second.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "hitEventThreshold")]
		[NativeName(NativeNameType.Type, "float")]
		public float HitEventThreshold;

		/// <summary>
		/// Contact stiffness. Cycles per second.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "contactHertz")]
		[NativeName(NativeNameType.Type, "float")]
		public float ContactHertz;

		/// <summary>
		/// Contact bounciness. Non-dimensional.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "contactDampingRatio")]
		[NativeName(NativeNameType.Type, "float")]
		public float ContactDampingRatio;

		/// <summary>
		/// Joint stiffness. Cycles per second.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "jointHertz")]
		[NativeName(NativeNameType.Type, "float")]
		public float JointHertz;

		/// <summary>
		/// Joint bounciness. Non-dimensional.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "jointDampingRatio")]
		[NativeName(NativeNameType.Type, "float")]
		public float JointDampingRatio;

		/// <summary>
		/// Maximum linear velocity. Usually meters per second.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "maximumLinearVelocity")]
		[NativeName(NativeNameType.Type, "float")]
		public float MaximumLinearVelocity;

		/// <summary>
		/// Can bodies go to sleep to improve performance<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "enableSleep")]
		[NativeName(NativeNameType.Type, "bool")]
		public byte EnableSleep;

		/// <summary>
		/// Enable continuous collision<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "enableContinous")]
		[NativeName(NativeNameType.Type, "bool")]
		public byte EnableContinous;

		/// <summary>
		/// Number of workers to use with the provided task system. Box2D performs best when using only<br/>
		/// performance cores and accessing a single L2 cache. Efficiency cores and hyper-threading provide<br/>
		/// little benefit and may even harm performance.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "workerCount")]
		[NativeName(NativeNameType.Type, "int32_t")]
		public int WorkerCount;

		/// <summary>
		/// Function to spawn tasks<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "enqueueTask")]
		[NativeName(NativeNameType.Type, "b2EnqueueTaskCallback *")]
		public unsafe delegate*<delegate*<int, int, uint, void*, void>*, int, int, void*, void*, void*>* EnqueueTask;

		/// <summary>
		/// Function to finish a task<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "finishTask")]
		[NativeName(NativeNameType.Type, "b2FinishTaskCallback *")]
		public unsafe delegate*<void*, void*, void>* FinishTask;

		/// <summary>
		/// User context that is provided to enqueueTask and finishTask<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "userTaskContext")]
		[NativeName(NativeNameType.Type, "void *")]
		public unsafe void* UserTaskContext;

		/// <summary>
		/// Used internally to detect a valid definition. DO NOT SET.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "internalValue")]
		[NativeName(NativeNameType.Type, "int32_t")]
		public int InternalValue;


		public unsafe B2WorldDef(Vector2 gravity = default, float restitutionThreshold = default, float contactPushoutVelocity = default, float hitEventThreshold = default, float contactHertz = default, float contactDampingRatio = default, float jointHertz = default, float jointDampingRatio = default, float maximumLinearVelocity = default, bool enableSleep = default, bool enableContinous = default, int workerCount = default, delegate*<delegate*<int, int, uint, void*, void>*, int, int, void*, void*, void*>* enqueueTask = default, delegate*<void*, void*, void>* finishTask = default, void* userTaskContext = default, int internalValue = default)
		{
			Gravity = gravity;
			RestitutionThreshold = restitutionThreshold;
			ContactPushoutVelocity = contactPushoutVelocity;
			HitEventThreshold = hitEventThreshold;
			ContactHertz = contactHertz;
			ContactDampingRatio = contactDampingRatio;
			JointHertz = jointHertz;
			JointDampingRatio = jointDampingRatio;
			MaximumLinearVelocity = maximumLinearVelocity;
			EnableSleep = enableSleep ? (byte)1 : (byte)0;
			EnableContinous = enableContinous ? (byte)1 : (byte)0;
			WorkerCount = workerCount;
			EnqueueTask = (delegate*<delegate*<int, int, uint, void*, void>*, int, int, void*, void*, void*>*)enqueueTask;
			FinishTask = (delegate*<void*, void*, void>*)finishTask;
			UserTaskContext = userTaskContext;
			InternalValue = internalValue;
		}


	}

}
