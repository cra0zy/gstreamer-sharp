// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.MetaFlagsGType))]
	public enum MetaFlags {

		None = 0,
		Readonly = 1,
		Pooled = 2,
		Locked = 4,
		Last = 65536,
	}

	internal class MetaFlagsGType {
		[DllImport ("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_meta_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_meta_flags_get_type ());
			}
		}
	}
#endregion
}
