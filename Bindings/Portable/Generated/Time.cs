// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// Time.cs
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

namespace Urho
{
	/// <summary>
	/// %Time and frame counter subsystem.
	/// </summary>
	public unsafe partial class Time : UrhoObject
	{
		[Preserve]
		public Time (IntPtr handle) : base (handle)
		{
		}

		[Preserve]
		protected Time (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Time_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (Time_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Time_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (Time_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Time_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(Time));
			return new StringHash (Time_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Time_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(Time));
			return Marshal.PtrToStringAnsi (Time_GetTypeNameStatic ());
		}

		public Time () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Time_Time (IntPtr context);

		public Time (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(Time));
			handle = Time_Time ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Time_BeginFrame (IntPtr handle, float timeStep);

		/// <summary>
		/// Begin new frame, with (last) frame duration in seconds and send frame start event.
		/// </summary>
		public void BeginFrame (float timeStep)
		{
			Runtime.ValidateRefCounted (this);
			Time_BeginFrame (handle, timeStep);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Time_EndFrame (IntPtr handle);

		/// <summary>
		/// End frame. Increment total time and send frame end event.
		/// </summary>
		public void EndFrame ()
		{
			Runtime.ValidateRefCounted (this);
			Time_EndFrame (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Time_SetTimerPeriod (IntPtr handle, uint mSec);

		/// <summary>
		/// Set the low-resolution timer period in milliseconds. 0 resets to the default period.
		/// </summary>
		private void SetTimerPeriod (uint mSec)
		{
			Runtime.ValidateRefCounted (this);
			Time_SetTimerPeriod (handle, mSec);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Time_GetFrameNumber (IntPtr handle);

		/// <summary>
		/// Return frame number, starting from 1 once BeginFrame() is called for the first time.
		/// </summary>
		private uint GetFrameNumber ()
		{
			Runtime.ValidateRefCounted (this);
			return Time_GetFrameNumber (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Time_GetTimeStep (IntPtr handle);

		/// <summary>
		/// Return current frame timestep as seconds.
		/// </summary>
		private float GetTimeStep ()
		{
			Runtime.ValidateRefCounted (this);
			return Time_GetTimeStep (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Time_GetTimerPeriod (IntPtr handle);

		/// <summary>
		/// Return current low-resolution timer period in milliseconds.
		/// </summary>
		private uint GetTimerPeriod ()
		{
			Runtime.ValidateRefCounted (this);
			return Time_GetTimerPeriod (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Time_GetElapsedTime (IntPtr handle);

		/// <summary>
		/// Return elapsed time from program start as seconds.
		/// </summary>
		private float GetElapsedTime ()
		{
			Runtime.ValidateRefCounted (this);
			return Time_GetElapsedTime (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Time_GetSystemTime ();

		/// <summary>
		/// Get system time as milliseconds.
		/// </summary>
		private static uint GetSystemTime ()
		{
			Runtime.Validate (typeof(Time));
			return Time_GetSystemTime ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Time_GetTimeSinceEpoch ();

		/// <summary>
		/// Get system time as seconds since 1.1.1970.
		/// </summary>
		private static uint GetTimeSinceEpoch ()
		{
			Runtime.Validate (typeof(Time));
			return Time_GetTimeSinceEpoch ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Time_GetTimeStamp ();

		/// <summary>
		/// Get a date/time stamp as a string.
		/// </summary>
		private static string GetTimeStamp ()
		{
			Runtime.Validate (typeof(Time));
			return Marshal.PtrToStringAnsi (Time_GetTimeStamp ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Time_Sleep (uint mSec);

		/// <summary>
		/// Sleep for a number of milliseconds.
		/// </summary>
		public static void Sleep (uint mSec)
		{
			Runtime.Validate (typeof(Time));
			Time_Sleep (mSec);
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

		public static StringHash TypeStatic {
			get {
				return GetTypeStatic ();
			}
		}

		public static string TypeNameStatic {
			get {
				return GetTypeNameStatic ();
			}
		}

		/// <summary>
		/// Return current low-resolution timer period in milliseconds.
		/// Or
		/// Set the low-resolution timer period in milliseconds. 0 resets to the default period.
		/// </summary>
		public uint TimerPeriod {
			get {
				return GetTimerPeriod ();
			}
			set {
				SetTimerPeriod (value);
			}
		}

		/// <summary>
		/// Return frame number, starting from 1 once BeginFrame() is called for the first time.
		/// </summary>
		public uint FrameNumber {
			get {
				return GetFrameNumber ();
			}
		}

		/// <summary>
		/// Return current frame timestep as seconds.
		/// </summary>
		public float TimeStep {
			get {
				return GetTimeStep ();
			}
		}

		/// <summary>
		/// Return elapsed time from program start as seconds.
		/// </summary>
		public float ElapsedTime {
			get {
				return GetElapsedTime ();
			}
		}

		/// <summary>
		/// Get system time as milliseconds.
		/// </summary>
		public static uint SystemTime {
			get {
				return GetSystemTime ();
			}
		}

		/// <summary>
		/// Get system time as seconds since 1.1.1970.
		/// </summary>
		public static uint TimeSinceEpoch {
			get {
				return GetTimeSinceEpoch ();
			}
		}

		/// <summary>
		/// Get a date/time stamp as a string.
		/// </summary>
		public static string TimeStamp {
			get {
				return GetTimeStamp ();
			}
		}
	}
}
