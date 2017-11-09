// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct Uri : IEquatable<Uri> {


		public static Gst.Uri Zero = new Gst.Uri ();

		public static Gst.Uri New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Uri.Zero;
			return (Gst.Uri) Marshal.PtrToStructure (raw, typeof (Gst.Uri));
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_uri_new(IntPtr scheme, IntPtr userinfo, IntPtr host, uint port, IntPtr path, IntPtr query, IntPtr fragment);

		public static Uri New(string scheme, string userinfo, string host, uint port, string path, string query, string fragment)
		{
			IntPtr native_scheme = GLib.Marshaller.StringToPtrGStrdup (scheme);
			IntPtr native_userinfo = GLib.Marshaller.StringToPtrGStrdup (userinfo);
			IntPtr native_host = GLib.Marshaller.StringToPtrGStrdup (host);
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr native_query = GLib.Marshaller.StringToPtrGStrdup (query);
			IntPtr native_fragment = GLib.Marshaller.StringToPtrGStrdup (fragment);
			Uri result = Uri.New (gst_uri_new(native_scheme, native_userinfo, native_host, port, native_path, native_query, native_fragment));
			GLib.Marshaller.Free (native_scheme);
			GLib.Marshaller.Free (native_userinfo);
			GLib.Marshaller.Free (native_host);
			GLib.Marshaller.Free (native_path);
			GLib.Marshaller.Free (native_query);
			GLib.Marshaller.Free (native_fragment);
			return result;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_uri_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_uri_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_uri_append_path(IntPtr raw, IntPtr relative_path);

		public bool AppendPath(string relative_path) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_relative_path = GLib.Marshaller.StringToPtrGStrdup (relative_path);
			bool raw_ret = gst_uri_append_path(this_as_native, native_relative_path);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_relative_path);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_uri_append_path_segment(IntPtr raw, IntPtr path_segment);

		public bool AppendPathSegment(string path_segment) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_path_segment = GLib.Marshaller.StringToPtrGStrdup (path_segment);
			bool raw_ret = gst_uri_append_path_segment(this_as_native, native_path_segment);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_path_segment);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_uri_equal(IntPtr raw, IntPtr second);

		public bool Equal(Gst.Uri second) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_second = GLib.Marshaller.StructureToPtrAlloc (second);
			bool raw_ret = gst_uri_equal(this_as_native, native_second);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			Marshal.FreeHGlobal (native_second);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_uri_from_string_with_base(IntPtr raw, IntPtr uri);

		public Gst.Uri FromStringWithBase(string uri) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr raw_ret = gst_uri_from_string_with_base(this_as_native, native_uri);
			Gst.Uri ret = Gst.Uri.New (raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_uri);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_uri_get_fragment(IntPtr raw);

		public string Fragment { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				IntPtr raw_ret = gst_uri_get_fragment(this_as_native);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_uri_get_host(IntPtr raw);

		public string Host { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				IntPtr raw_ret = gst_uri_get_host(this_as_native);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern System.IntPtr gst_uri_get_media_fragment_table(IntPtr raw);

		public string[] MediaFragmentTable { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				System.IntPtr raw_ret = gst_uri_get_media_fragment_table(this_as_native);
				string[] ret = (string[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(System.IntPtr), true, true, typeof(string));
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_uri_get_path(IntPtr raw);

		public string Path { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				IntPtr raw_ret = gst_uri_get_path(this_as_native);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_uri_get_path_segments(IntPtr raw);

		public string[] PathSegments { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				IntPtr raw_ret = gst_uri_get_path_segments(this_as_native);
				string[] ret = (string[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(string));
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_uri_get_path_string(IntPtr raw);

		public string PathString { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				IntPtr raw_ret = gst_uri_get_path_string(this_as_native);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_uri_get_port(IntPtr raw);

		public uint Port { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				uint raw_ret = gst_uri_get_port(this_as_native);
				uint ret = raw_ret;
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_uri_get_query_keys(IntPtr raw);

		public string[] QueryKeys { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				IntPtr raw_ret = gst_uri_get_query_keys(this_as_native);
				string[] ret = (string[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), false, true, typeof(string));
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_uri_get_query_string(IntPtr raw);

		public string QueryString { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				IntPtr raw_ret = gst_uri_get_query_string(this_as_native);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern System.IntPtr gst_uri_get_query_table(IntPtr raw);

		public string[] QueryTable { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				System.IntPtr raw_ret = gst_uri_get_query_table(this_as_native);
				string[] ret = (string[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(System.IntPtr), true, true, typeof(string));
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_uri_get_query_value(IntPtr raw, IntPtr query_key);

		public string GetQueryValue(string query_key) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_query_key = GLib.Marshaller.StringToPtrGStrdup (query_key);
			IntPtr raw_ret = gst_uri_get_query_value(this_as_native, native_query_key);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_query_key);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_uri_get_scheme(IntPtr raw);

		public string Scheme { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				IntPtr raw_ret = gst_uri_get_scheme(this_as_native);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_uri_get_userinfo(IntPtr raw);

		public string Userinfo { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				IntPtr raw_ret = gst_uri_get_userinfo(this_as_native);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_uri_is_normalized(IntPtr raw);

		public bool IsNormalized { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				bool raw_ret = gst_uri_is_normalized(this_as_native);
				bool ret = raw_ret;
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_uri_is_writable(IntPtr raw);

		public bool IsWritable { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				bool raw_ret = gst_uri_is_writable(this_as_native);
				bool ret = raw_ret;
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_uri_join(IntPtr raw, IntPtr ref_uri);

		public Gst.Uri Join(Gst.Uri ref_uri) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_ref_uri = GLib.Marshaller.StructureToPtrAlloc (ref_uri);
			IntPtr raw_ret = gst_uri_join(this_as_native, native_ref_uri);
			Gst.Uri ret = Gst.Uri.New (raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			Marshal.FreeHGlobal (native_ref_uri);
			return ret;
		}

		public Gst.Uri Join() {
			return Join (Gst.Uri.Zero);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_uri_make_writable(IntPtr raw);

		public Gst.Uri MakeWritable() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr raw_ret = gst_uri_make_writable(this_as_native);
			Gst.Uri ret = Gst.Uri.New (raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_uri_new_with_base(IntPtr raw, IntPtr scheme, IntPtr userinfo, IntPtr host, uint port, IntPtr path, IntPtr query, IntPtr fragment);

		public Gst.Uri NewWithBase(string scheme, string userinfo, string host, uint port, string path, string query, string fragment) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_scheme = GLib.Marshaller.StringToPtrGStrdup (scheme);
			IntPtr native_userinfo = GLib.Marshaller.StringToPtrGStrdup (userinfo);
			IntPtr native_host = GLib.Marshaller.StringToPtrGStrdup (host);
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr native_query = GLib.Marshaller.StringToPtrGStrdup (query);
			IntPtr native_fragment = GLib.Marshaller.StringToPtrGStrdup (fragment);
			IntPtr raw_ret = gst_uri_new_with_base(this_as_native, native_scheme, native_userinfo, native_host, port, native_path, native_query, native_fragment);
			Gst.Uri ret = Gst.Uri.New (raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_scheme);
			GLib.Marshaller.Free (native_userinfo);
			GLib.Marshaller.Free (native_host);
			GLib.Marshaller.Free (native_path);
			GLib.Marshaller.Free (native_query);
			GLib.Marshaller.Free (native_fragment);
			return ret;
		}

		public Gst.Uri NewWithBase(uint port) {
			return NewWithBase (null, null, null, port, null, null, null);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_uri_normalize(IntPtr raw);

		public bool Normalize() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			bool raw_ret = gst_uri_normalize(this_as_native);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_uri_query_has_key(IntPtr raw, IntPtr query_key);

		public bool QueryHasKey(string query_key) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_query_key = GLib.Marshaller.StringToPtrGStrdup (query_key);
			bool raw_ret = gst_uri_query_has_key(this_as_native, native_query_key);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_query_key);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_uri_remove_query_key(IntPtr raw, IntPtr query_key);

		public bool RemoveQueryKey(string query_key) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_query_key = GLib.Marshaller.StringToPtrGStrdup (query_key);
			bool raw_ret = gst_uri_remove_query_key(this_as_native, native_query_key);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_query_key);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_uri_set_fragment(IntPtr raw, IntPtr fragment);

		public bool SetFragment(string fragment) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_fragment = GLib.Marshaller.StringToPtrGStrdup (fragment);
			bool raw_ret = gst_uri_set_fragment(this_as_native, native_fragment);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_fragment);
			return ret;
		}

		public bool SetFragment() {
			return SetFragment (null);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_uri_set_host(IntPtr raw, IntPtr host);

		public bool SetHost(string host) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_host = GLib.Marshaller.StringToPtrGStrdup (host);
			bool raw_ret = gst_uri_set_host(this_as_native, native_host);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_host);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_uri_set_path(IntPtr raw, IntPtr path);

		public bool SetPath(string path) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			bool raw_ret = gst_uri_set_path(this_as_native, native_path);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_path);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_uri_set_path_segments(IntPtr raw, IntPtr path_segments);

		public bool SetPathSegments(GLib.List path_segments) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			bool raw_ret = gst_uri_set_path_segments(this_as_native, path_segments == null ? IntPtr.Zero : path_segments.Handle);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		public bool SetPathSegments() {
			return SetPathSegments (null);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_uri_set_path_string(IntPtr raw, IntPtr path);

		public bool SetPathString(string path) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			bool raw_ret = gst_uri_set_path_string(this_as_native, native_path);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_path);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_uri_set_port(IntPtr raw, uint port);

		public bool SetPort(uint port) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			bool raw_ret = gst_uri_set_port(this_as_native, port);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_uri_set_query_string(IntPtr raw, IntPtr query);

		public bool SetQueryString(string query) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_query = GLib.Marshaller.StringToPtrGStrdup (query);
			bool raw_ret = gst_uri_set_query_string(this_as_native, native_query);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_query);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_uri_set_query_table(IntPtr raw, System.IntPtr query_table);

		public bool SetQueryTable(System.IntPtr query_table) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			bool raw_ret = gst_uri_set_query_table(this_as_native, query_table);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		public bool SetQueryTable() {
			return SetQueryTable (IntPtr.Zero);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_uri_set_query_value(IntPtr raw, IntPtr query_key, IntPtr query_value);

		public bool SetQueryValue(string query_key, string query_value) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_query_key = GLib.Marshaller.StringToPtrGStrdup (query_key);
			IntPtr native_query_value = GLib.Marshaller.StringToPtrGStrdup (query_value);
			bool raw_ret = gst_uri_set_query_value(this_as_native, native_query_key, native_query_value);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_query_key);
			GLib.Marshaller.Free (native_query_value);
			return ret;
		}

		public bool SetQueryValue(string query_key) {
			return SetQueryValue (query_key, null);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_uri_set_scheme(IntPtr raw, IntPtr scheme);

		public bool SetScheme(string scheme) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_scheme = GLib.Marshaller.StringToPtrGStrdup (scheme);
			bool raw_ret = gst_uri_set_scheme(this_as_native, native_scheme);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_scheme);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_uri_set_userinfo(IntPtr raw, IntPtr userinfo);

		public bool SetUserinfo(string userinfo) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_userinfo = GLib.Marshaller.StringToPtrGStrdup (userinfo);
			bool raw_ret = gst_uri_set_userinfo(this_as_native, native_userinfo);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_userinfo);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_uri_to_string(IntPtr raw);

		public override string ToString() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr raw_ret = gst_uri_to_string(this_as_native);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_uri_construct(IntPtr protocol, IntPtr location);

		public static string Construct(string protocol, string location) {
			IntPtr native_protocol = GLib.Marshaller.StringToPtrGStrdup (protocol);
			IntPtr native_location = GLib.Marshaller.StringToPtrGStrdup (location);
			IntPtr raw_ret = gst_uri_construct(native_protocol, native_location);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_protocol);
			GLib.Marshaller.Free (native_location);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_uri_from_string(IntPtr uri);

		public static Gst.Uri FromString(string uri) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr raw_ret = gst_uri_from_string(native_uri);
			Gst.Uri ret = Gst.Uri.New (raw_ret);
			GLib.Marshaller.Free (native_uri);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_uri_get_location(IntPtr uri);

		public static string GetLocation(string uri) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr raw_ret = gst_uri_get_location(native_uri);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_uri);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_uri_get_protocol(IntPtr uri);

		public static string GetProtocol(string uri) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr raw_ret = gst_uri_get_protocol(native_uri);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_uri);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_uri_has_protocol(IntPtr uri, IntPtr protocol);

		public static bool HasProtocol(string uri, string protocol) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr native_protocol = GLib.Marshaller.StringToPtrGStrdup (protocol);
			bool raw_ret = gst_uri_has_protocol(native_uri, native_protocol);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_uri);
			GLib.Marshaller.Free (native_protocol);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_uri_is_valid(IntPtr uri);

		public static bool IsValid(string uri) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			bool raw_ret = gst_uri_is_valid(native_uri);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_uri);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_uri_join_strings(IntPtr base_uri, IntPtr ref_uri);

		public static string JoinStrings(string base_uri, string ref_uri) {
			IntPtr native_base_uri = GLib.Marshaller.StringToPtrGStrdup (base_uri);
			IntPtr native_ref_uri = GLib.Marshaller.StringToPtrGStrdup (ref_uri);
			IntPtr raw_ret = gst_uri_join_strings(native_base_uri, native_ref_uri);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_base_uri);
			GLib.Marshaller.Free (native_ref_uri);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_uri_protocol_is_supported(int type, IntPtr protocol);

		public static bool ProtocolIsSupported(Gst.URIType type, string protocol) {
			IntPtr native_protocol = GLib.Marshaller.StringToPtrGStrdup (protocol);
			bool raw_ret = gst_uri_protocol_is_supported((int) type, native_protocol);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_protocol);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_uri_protocol_is_valid(IntPtr protocol);

		public static bool ProtocolIsValid(string protocol) {
			IntPtr native_protocol = GLib.Marshaller.StringToPtrGStrdup (protocol);
			bool raw_ret = gst_uri_protocol_is_valid(native_protocol);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_protocol);
			return ret;
		}

		static void ReadNative (IntPtr native, ref Gst.Uri target)
		{
			target = New (native);
		}

		public bool Equals (Uri other)
		{
			return true;
		}

		public override bool Equals (object other)
		{
			return other is Uri && Equals ((Uri) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode ();
		}

		public static explicit operator GLib.Value (Gst.Uri boxed)
		{
			GLib.Value val = GLib.Value.Empty;
			val.Init (Gst.Uri.GType);
			val.Val = boxed;
			return val;
		}

		public static explicit operator Gst.Uri (GLib.Value val)
		{
			return (Gst.Uri) val.Val;
		}
#endregion
	}
}
