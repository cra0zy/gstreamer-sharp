// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.PbUtils {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class EncodingTarget : GLib.Object {

		public EncodingTarget (IntPtr raw) : base(raw) {}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_encoding_target_new(IntPtr name, IntPtr category, IntPtr description, IntPtr profiles);

		public EncodingTarget (string name, string category, string description, GLib.List profiles) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (EncodingTarget)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr native_category = GLib.Marshaller.StringToPtrGStrdup (category);
			IntPtr native_description = GLib.Marshaller.StringToPtrGStrdup (description);
			Raw = gst_encoding_target_new(native_name, native_category, native_description, profiles == null ? IntPtr.Zero : profiles.Handle);
			GLib.Marshaller.Free (native_name);
			GLib.Marshaller.Free (native_category);
			GLib.Marshaller.Free (native_description);
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_encoding_target_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_encoding_target_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr gst_encoding_target_load(IntPtr name, IntPtr category, out IntPtr error);

		public static unsafe Gst.PbUtils.EncodingTarget Load(string name, string category) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr native_category = GLib.Marshaller.StringToPtrGStrdup (category);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = gst_encoding_target_load(native_name, native_category, out error);
			Gst.PbUtils.EncodingTarget ret = GLib.Object.GetObject(raw_ret, true) as Gst.PbUtils.EncodingTarget;
			GLib.Marshaller.Free (native_name);
			GLib.Marshaller.Free (native_category);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		public static Gst.PbUtils.EncodingTarget Load(string name) {
			return Load (name, null);
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr gst_encoding_target_load_from_file(IntPtr filepath, out IntPtr error);

		public static unsafe Gst.PbUtils.EncodingTarget LoadFromFile(string filepath) {
			IntPtr native_filepath = GLib.Marshaller.StringToPtrGStrdup (filepath);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = gst_encoding_target_load_from_file(native_filepath, out error);
			Gst.PbUtils.EncodingTarget ret = GLib.Object.GetObject(raw_ret, true) as Gst.PbUtils.EncodingTarget;
			GLib.Marshaller.Free (native_filepath);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_encoding_target_add_profile(IntPtr raw, IntPtr profile);

		public bool AddProfile(Gst.PbUtils.EncodingProfile profile) {
			bool raw_ret = gst_encoding_target_add_profile(Handle, profile == null ? IntPtr.Zero : profile.OwnedHandle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_encoding_target_get_category(IntPtr raw);

		public string Category { 
			get {
				IntPtr raw_ret = gst_encoding_target_get_category(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_encoding_target_get_description(IntPtr raw);

		public string Description { 
			get {
				IntPtr raw_ret = gst_encoding_target_get_description(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_encoding_target_get_name(IntPtr raw);

		public string Name { 
			get {
				IntPtr raw_ret = gst_encoding_target_get_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_encoding_target_get_profile(IntPtr raw, IntPtr name);

		public Gst.PbUtils.EncodingProfile GetProfile(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = gst_encoding_target_get_profile(Handle, native_name);
			Gst.PbUtils.EncodingProfile ret = GLib.Object.GetObject(raw_ret, true) as Gst.PbUtils.EncodingProfile;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_encoding_target_get_profiles(IntPtr raw);

		public Gst.PbUtils.EncodingProfile[] Profiles { 
			get {
				IntPtr raw_ret = gst_encoding_target_get_profiles(Handle);
				Gst.PbUtils.EncodingProfile[] ret = (Gst.PbUtils.EncodingProfile[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), false, false, typeof(Gst.PbUtils.EncodingProfile));
				return ret;
			}
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool gst_encoding_target_save(IntPtr raw, out IntPtr error);

		public unsafe bool Save() {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gst_encoding_target_save(Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool gst_encoding_target_save_to_file(IntPtr raw, IntPtr filepath, out IntPtr error);

		public unsafe bool SaveToFile(string filepath) {
			IntPtr native_filepath = GLib.Marshaller.StringToPtrGStrdup (filepath);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gst_encoding_target_save_to_file(Handle, native_filepath, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_filepath);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}


		static EncodingTarget ()
		{
			GtkSharp.GstSharp.ObjectManager.Initialize ();
		}
#endregion
	}
}
