// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// TmxFile2D.cs
// 
// Copyright 2015 Xamarin Inc. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Urho.Urho2D;
using Urho.Gui;
using Urho.Resources;
using Urho.IO;
using Urho.Navigation;
using Urho.Network;

namespace Urho.Urho2D
{
	/// <summary>
	/// Tile map file.
	/// </summary>
	public unsafe partial class TmxFile2D : Resource
	{
		[Preserve]
		public TmxFile2D (IntPtr handle) : base (handle)
		{
		}

		[Preserve]
		protected TmxFile2D (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int TmxFile2D_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (TmxFile2D_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr TmxFile2D_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (TmxFile2D_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int TmxFile2D_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(TmxFile2D));
			return new StringHash (TmxFile2D_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr TmxFile2D_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(TmxFile2D));
			return Marshal.PtrToStringAnsi (TmxFile2D_GetTypeNameStatic ());
		}

		public TmxFile2D () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr TmxFile2D_TmxFile2D (IntPtr context);

		public TmxFile2D (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(TmxFile2D));
			handle = TmxFile2D_TmxFile2D ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void TmxFile2D_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory.
		/// </summary>
		public static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(TmxFile2D));
			TmxFile2D_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool TmxFile2D_BeginLoad_File (IntPtr handle, IntPtr source);

		/// <summary>
		/// Load resource from stream. May be called from a worker thread. Return true if successful.
		/// </summary>
		public override bool BeginLoad (File source)
		{
			Runtime.ValidateRefCounted (this);
			return TmxFile2D_BeginLoad_File (handle, (object)source == null ? IntPtr.Zero : source.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool TmxFile2D_BeginLoad_MemoryBuffer (IntPtr handle, IntPtr source);

		/// <summary>
		/// Load resource from stream. May be called from a worker thread. Return true if successful.
		/// </summary>
		public override bool BeginLoad (MemoryBuffer source)
		{
			Runtime.ValidateRefCounted (this);
			return TmxFile2D_BeginLoad_MemoryBuffer (handle, (object)source == null ? IntPtr.Zero : source.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool TmxFile2D_EndLoad (IntPtr handle);

		/// <summary>
		/// Finish resource loading. Always called from the main thread. Return true if successful.
		/// </summary>
		public override bool EndLoad ()
		{
			Runtime.ValidateRefCounted (this);
			return TmxFile2D_EndLoad (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool TmxFile2D_SetInfo (IntPtr handle, Orientation2D orientation, int width, int height, float tileWidth, float tileHeight);

		/// <summary>
		/// Set Tilemap information.
		/// </summary>
		public bool SetInfo (Orientation2D orientation, int width, int height, float tileWidth, float tileHeight)
		{
			Runtime.ValidateRefCounted (this);
			return TmxFile2D_SetInfo (handle, orientation, width, height, tileWidth, tileHeight);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void TmxFile2D_AddLayer (IntPtr handle, uint index, IntPtr layer);

		/// <summary>
		/// Add layer at index, if index > number of layers then append to end.
		/// </summary>
		public void AddLayer (uint index, TmxLayer2D layer)
		{
			Runtime.ValidateRefCounted (this);
			TmxFile2D_AddLayer (handle, index, (object)layer == null ? IntPtr.Zero : layer.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Urho2D.TileMapInfo2D TmxFile2D_GetInfo (IntPtr handle);

		/// <summary>
		/// Return Tilemap information.
		/// </summary>
		private Urho.Urho2D.TileMapInfo2D GetInfo ()
		{
			Runtime.ValidateRefCounted (this);
			return TmxFile2D_GetInfo (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr TmxFile2D_GetTileSprite (IntPtr handle, int gid);

		/// <summary>
		/// Return tile sprite by gid, if not exist return 0.
		/// </summary>
		public Sprite2D GetTileSprite (int gid)
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Sprite2D> (TmxFile2D_GetTileSprite (handle, gid));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr TmxFile2D_GetTilePropertySet (IntPtr handle, int gid);

		/// <summary>
		/// Return tile property set by gid, if not exist return 0.
		/// </summary>
		public PropertySet2D GetTilePropertySet (int gid)
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupRefCounted<PropertySet2D> (TmxFile2D_GetTilePropertySet (handle, gid));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint TmxFile2D_GetNumLayers (IntPtr handle);

		/// <summary>
		/// Return number of layers.
		/// </summary>
		private uint GetNumLayers ()
		{
			Runtime.ValidateRefCounted (this);
			return TmxFile2D_GetNumLayers (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr TmxFile2D_GetLayer (IntPtr handle, uint index);

		/// <summary>
		/// Return layer at index.
		/// </summary>
		public TmxLayer2D GetLayer (uint index)
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupRefCounted<TmxLayer2D> (TmxFile2D_GetLayer (handle, index));
		}

		public override StringHash Type {
			get {
				return UrhoGetType ();
			}
		}

		public override string TypeName {
			get {
				return GetTypeName ();
			}
		}

		public new static StringHash TypeStatic {
			get {
				return GetTypeStatic ();
			}
		}

		public new static string TypeNameStatic {
			get {
				return GetTypeNameStatic ();
			}
		}

		/// <summary>
		/// Return Tilemap information.
		/// </summary>
		public Urho.Urho2D.TileMapInfo2D Info {
			get {
				return GetInfo ();
			}
		}

		/// <summary>
		/// Return number of layers.
		/// </summary>
		public uint NumLayers {
			get {
				return GetNumLayers ();
			}
		}
	}
}
