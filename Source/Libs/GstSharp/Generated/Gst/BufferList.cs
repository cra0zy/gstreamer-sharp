// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class BufferList : GLib.Opaque {

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_list_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_buffer_list_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern UIntPtr gst_buffer_list_calculate_size(IntPtr raw);

		public ulong CalculateSize() {
			UIntPtr raw_ret = gst_buffer_list_calculate_size(Handle);
			ulong ret = (ulong) raw_ret;
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_list_copy_deep(IntPtr raw);

		public Gst.BufferList CopyDeep() {
			IntPtr raw_ret = gst_buffer_list_copy_deep(Handle);
			Gst.BufferList ret = raw_ret == IntPtr.Zero ? null : (Gst.BufferList) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.BufferList), true);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_buffer_list_foreach(IntPtr raw, GstSharp.BufferListFuncNative func, IntPtr user_data);

		public bool Foreach(Gst.BufferListFunc func) {
			GstSharp.BufferListFuncWrapper func_wrapper = new GstSharp.BufferListFuncWrapper (func);
			bool raw_ret = gst_buffer_list_foreach(Handle, func_wrapper.NativeDelegate, IntPtr.Zero);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_list_get(IntPtr raw, uint idx);

		public Gst.Buffer Get(uint idx) {
			IntPtr raw_ret = gst_buffer_list_get(Handle, idx);
			Gst.Buffer ret = raw_ret == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Buffer), false);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_list_get_writable(IntPtr raw, uint idx);

		public Gst.Buffer GetWritable(uint idx) {
			IntPtr raw_ret = gst_buffer_list_get_writable(Handle, idx);
			Gst.Buffer ret = raw_ret == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Buffer), false);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_buffer_list_insert(IntPtr raw, int idx, IntPtr buffer);

		public void Insert(int idx, Gst.Buffer buffer) {
			buffer.Owned = false;
			gst_buffer_list_insert(Handle, idx, buffer == null ? IntPtr.Zero : buffer.Handle);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_buffer_list_length(IntPtr raw);

		public uint Length() {
			uint raw_ret = gst_buffer_list_length(Handle);
			uint ret = raw_ret;
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_buffer_list_remove(IntPtr raw, uint idx, uint length);

		public void Remove(uint idx, uint length) {
			gst_buffer_list_remove(Handle, idx, length);
		}

		public BufferList(IntPtr raw) : base(raw) {}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_list_new();

		public BufferList () 
		{
			Raw = gst_buffer_list_new();
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffer_list_new_sized(uint size);

		public BufferList (uint size) 
		{
			Raw = gst_buffer_list_new_sized(size);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
