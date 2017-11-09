// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Memory : Gst.MiniObject {

		public Gst.Allocator Allocator {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("allocator"));
					return GLib.Object.GetObject((*raw_ptr)) as Gst.Allocator;
				}
			}
			set {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("allocator"));
					*raw_ptr = value == null ? IntPtr.Zero : value.Handle;
				}
			}
		}

		public Gst.Memory Parent {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("parent"));
					return (*raw_ptr) == IntPtr.Zero ? null : (Gst.Memory) GLib.Opaque.GetOpaque ((*raw_ptr), typeof (Gst.Memory), false);
				}
			}
			set {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("parent"));
					*raw_ptr = value == null ? IntPtr.Zero : value.Handle;
				}
			}
		}

		public ulong Maxsize {
			get {
				unsafe {
					UIntPtr* raw_ptr = (UIntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("maxsize"));
					return (ulong) (*raw_ptr);
				}
			}
			set {
				unsafe {
					UIntPtr* raw_ptr = (UIntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("maxsize"));
					*raw_ptr = new UIntPtr (value);
				}
			}
		}

		public ulong Align {
			get {
				unsafe {
					UIntPtr* raw_ptr = (UIntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("align"));
					return (ulong) (*raw_ptr);
				}
			}
			set {
				unsafe {
					UIntPtr* raw_ptr = (UIntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("align"));
					*raw_ptr = new UIntPtr (value);
				}
			}
		}

		public ulong Offset {
			get {
				unsafe {
					UIntPtr* raw_ptr = (UIntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("offset"));
					return (ulong) (*raw_ptr);
				}
			}
			set {
				unsafe {
					UIntPtr* raw_ptr = (UIntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("offset"));
					*raw_ptr = new UIntPtr (value);
				}
			}
		}

		public ulong Size {
			get {
				unsafe {
					UIntPtr* raw_ptr = (UIntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("size"));
					return (ulong) (*raw_ptr);
				}
			}
			set {
				unsafe {
					UIntPtr* raw_ptr = (UIntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("size"));
					*raw_ptr = new UIntPtr (value);
				}
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_memory_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_memory_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_memory_copy(IntPtr raw, IntPtr offset, IntPtr size);

		public Gst.Memory Copy(long offset, long size) {
			IntPtr raw_ret = gst_memory_copy(Handle, new IntPtr (offset), new IntPtr (size));
			Gst.Memory ret = raw_ret == IntPtr.Zero ? null : (Gst.Memory) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Memory), true);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern UIntPtr gst_memory_get_sizes(IntPtr raw, UIntPtr offset, UIntPtr maxsize);

		public ulong GetSizes(ulong offset, ulong maxsize) {
			UIntPtr raw_ret = gst_memory_get_sizes(Handle, new UIntPtr (offset), new UIntPtr (maxsize));
			ulong ret = (ulong) raw_ret;
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_memory_is_span(IntPtr raw, IntPtr mem2, UIntPtr offset);

		public bool IsSpan(Gst.Memory mem2, ulong offset) {
			bool raw_ret = gst_memory_is_span(Handle, mem2 == null ? IntPtr.Zero : mem2.Handle, new UIntPtr (offset));
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_memory_is_type(IntPtr raw, IntPtr mem_type);

		public bool IsType(string mem_type) {
			IntPtr native_mem_type = GLib.Marshaller.StringToPtrGStrdup (mem_type);
			bool raw_ret = gst_memory_is_type(Handle, native_mem_type);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_mem_type);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_memory_make_mapped(IntPtr raw, IntPtr info, int flags);

		public Gst.Memory MakeMapped(out Gst.MapInfo info, Gst.MapFlags flags) {
			IntPtr native_info = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gst.MapInfo)));
			IntPtr raw_ret = gst_memory_make_mapped(Handle, native_info, (int) flags);
			Gst.Memory ret = raw_ret == IntPtr.Zero ? null : (Gst.Memory) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Memory), true);
			info = Gst.MapInfo.New (native_info);
			Marshal.FreeHGlobal (native_info);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_memory_map(IntPtr raw, IntPtr info, int flags);

		public bool Map(out Gst.MapInfo info, Gst.MapFlags flags) {
			IntPtr native_info = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gst.MapInfo)));
			bool raw_ret = gst_memory_map(Handle, native_info, (int) flags);
			bool ret = raw_ret;
			info = Gst.MapInfo.New (native_info);
			Marshal.FreeHGlobal (native_info);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_memory_resize(IntPtr raw, IntPtr offset, UIntPtr size);

		public void Resize(long offset, ulong size) {
			gst_memory_resize(Handle, new IntPtr (offset), new UIntPtr (size));
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_memory_share(IntPtr raw, IntPtr offset, IntPtr size);

		public Gst.Memory Share(long offset, long size) {
			IntPtr raw_ret = gst_memory_share(Handle, new IntPtr (offset), new IntPtr (size));
			Gst.Memory ret = raw_ret == IntPtr.Zero ? null : (Gst.Memory) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Memory), true);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_memory_unmap(IntPtr raw, IntPtr info);

		public void Unmap(Gst.MapInfo info) {
			IntPtr native_info = GLib.Marshaller.StructureToPtrAlloc (info);
			gst_memory_unmap(Handle, native_info);
			Marshal.FreeHGlobal (native_info);
		}

		public Memory(IntPtr raw) : base(raw) {}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_memory_new_wrapped(int flags, byte[] data, UIntPtr maxsize, UIntPtr offset, UIntPtr size, IntPtr user_data, GLib.DestroyNotify notify);

		public Memory (Gst.MemoryFlags flags, byte[] data, ulong maxsize, ulong offset, ulong size, IntPtr user_data, GLib.DestroyNotify notify) 
		{
			Raw = gst_memory_new_wrapped((int) flags, data, new UIntPtr (maxsize), new UIntPtr (offset), new UIntPtr (size), user_data, notify);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("allocator"
							, Gst.MiniObject.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // allocator
							, null
							, "parent"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("parent"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // parent
							, "allocator"
							, "maxsize"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("maxsize"
							, -1
							, (uint) Marshal.SizeOf(typeof(ulong)) // maxsize
							, "parent"
							, "align"
							, (long) Marshal.OffsetOf(typeof(GstMemory_maxsizeAlign), "maxsize")
							, 0
							),
						new GLib.AbiField("align"
							, -1
							, (uint) Marshal.SizeOf(typeof(ulong)) // align
							, "maxsize"
							, "offset"
							, (long) Marshal.OffsetOf(typeof(GstMemory_alignAlign), "align")
							, 0
							),
						new GLib.AbiField("offset"
							, -1
							, (uint) Marshal.SizeOf(typeof(ulong)) // offset
							, "align"
							, "size"
							, (long) Marshal.OffsetOf(typeof(GstMemory_offsetAlign), "offset")
							, 0
							),
						new GLib.AbiField("size"
							, -1
							, (uint) Marshal.SizeOf(typeof(ulong)) // size
							, "offset"
							, null
							, (long) Marshal.OffsetOf(typeof(GstMemory_sizeAlign), "size")
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstMemory_maxsizeAlign
		{
			sbyte f1;
			private UIntPtr maxsize;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstMemory_alignAlign
		{
			sbyte f1;
			private UIntPtr align;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstMemory_offsetAlign
		{
			sbyte f1;
			private UIntPtr offset;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstMemory_sizeAlign
		{
			sbyte f1;
			private UIntPtr size;
		}


		// End of the ABI representation.

#endregion
	}
}
