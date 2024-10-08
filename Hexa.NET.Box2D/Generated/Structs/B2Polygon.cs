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
	/// A solid convex polygon. It is assumed that the interior of the polygon is to<br/>
	/// the left of each edge.<br/>
	/// Polygons have a maximum number of vertices equal to b2_maxPolygonVertices.<br/>
	/// In most cases you should not need many vertices for a convex polygon.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "b2Polygon")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct B2Polygon
	{
		/// <summary>
		/// The polygon vertices<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "vertices")]
		[NativeName(NativeNameType.Type, "b2Vec2[8]")]
		public Vector2 Vertices_0;
		public Vector2 Vertices_1;
		public Vector2 Vertices_2;
		public Vector2 Vertices_3;
		public Vector2 Vertices_4;
		public Vector2 Vertices_5;
		public Vector2 Vertices_6;
		public Vector2 Vertices_7;

		/// <summary>
		/// The outward normal vectors of the polygon sides<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "normals")]
		[NativeName(NativeNameType.Type, "b2Vec2[8]")]
		public Vector2 Normals_0;
		public Vector2 Normals_1;
		public Vector2 Normals_2;
		public Vector2 Normals_3;
		public Vector2 Normals_4;
		public Vector2 Normals_5;
		public Vector2 Normals_6;
		public Vector2 Normals_7;

		/// <summary>
		/// The centroid of the polygon<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "centroid")]
		[NativeName(NativeNameType.Type, "b2Vec2")]
		public Vector2 Centroid;

		/// <summary>
		/// The external radius for rounded polygons<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "radius")]
		[NativeName(NativeNameType.Type, "float")]
		public float Radius;

		/// <summary>
		/// The number of polygon vertices<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "count")]
		[NativeName(NativeNameType.Type, "int32_t")]
		public int Count;


		public unsafe B2Polygon(Vector2* vertices = default, Vector2* normals = default, Vector2 centroid = default, float radius = default, int count = default)
		{
			if (vertices != default(Vector2*))
			{
				Vertices_0 = vertices[0];
				Vertices_1 = vertices[1];
				Vertices_2 = vertices[2];
				Vertices_3 = vertices[3];
				Vertices_4 = vertices[4];
				Vertices_5 = vertices[5];
				Vertices_6 = vertices[6];
				Vertices_7 = vertices[7];
			}
			if (normals != default(Vector2*))
			{
				Normals_0 = normals[0];
				Normals_1 = normals[1];
				Normals_2 = normals[2];
				Normals_3 = normals[3];
				Normals_4 = normals[4];
				Normals_5 = normals[5];
				Normals_6 = normals[6];
				Normals_7 = normals[7];
			}
			Centroid = centroid;
			Radius = radius;
			Count = count;
		}

		public unsafe B2Polygon(Span<Vector2> vertices = default, Span<Vector2> normals = default, Vector2 centroid = default, float radius = default, int count = default)
		{
			if (vertices != default(Span<Vector2>))
			{
				Vertices_0 = vertices[0];
				Vertices_1 = vertices[1];
				Vertices_2 = vertices[2];
				Vertices_3 = vertices[3];
				Vertices_4 = vertices[4];
				Vertices_5 = vertices[5];
				Vertices_6 = vertices[6];
				Vertices_7 = vertices[7];
			}
			if (normals != default(Span<Vector2>))
			{
				Normals_0 = normals[0];
				Normals_1 = normals[1];
				Normals_2 = normals[2];
				Normals_3 = normals[3];
				Normals_4 = normals[4];
				Normals_5 = normals[5];
				Normals_6 = normals[6];
				Normals_7 = normals[7];
			}
			Centroid = centroid;
			Radius = radius;
			Count = count;
		}


		/// <summary>
		/// The polygon vertices<br/>
		/// </summary>
		public unsafe Span<Vector2> Vertices
		
		{
			get
			{
				fixed (Vector2* p = &this.Vertices_0)
				{
					return new Span<Vector2>(p, 8);
				}
			}
		}
		/// <summary>
		/// The outward normal vectors of the polygon sides<br/>
		/// </summary>
		public unsafe Span<Vector2> Normals
		
		{
			get
			{
				fixed (Vector2* p = &this.Normals_0)
				{
					return new Span<Vector2>(p, 8);
				}
			}
		}
	}

}
