// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ReferenceTimestampMeta : IEquatable<ReferenceTimestampMeta> {

		public Gst.Meta Parent;
		private IntPtr _reference;
		public Gst.Caps Reference {
			get {
				return _reference == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (_reference, typeof (Gst.Caps), false);
			}
			set {
				_reference = value == null ? IntPtr.Zero : value.Handle;
			}
		}
		public ulong Timestamp;
		public ulong Duration;

		public static Gst.ReferenceTimestampMeta Zero = new Gst.ReferenceTimestampMeta ();

		public static Gst.ReferenceTimestampMeta New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.ReferenceTimestampMeta.Zero;
			return (Gst.ReferenceTimestampMeta) Marshal.PtrToStructure (raw, typeof (Gst.ReferenceTimestampMeta));
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_reference_timestamp_meta_get_info();

		public static Gst.MetaInfo Info { 
			get {
				IntPtr raw_ret = gst_reference_timestamp_meta_get_info();
				Gst.MetaInfo ret = Gst.MetaInfo.New (raw_ret);
				return ret;
			}
		}

		public bool Equals (ReferenceTimestampMeta other)
		{
			return true && Parent.Equals (other.Parent) && Reference.Equals (other.Reference) && Timestamp.Equals (other.Timestamp) && Duration.Equals (other.Duration);
		}

		public override bool Equals (object other)
		{
			return other is ReferenceTimestampMeta && Equals ((ReferenceTimestampMeta) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Parent.GetHashCode () ^ Reference.GetHashCode () ^ Timestamp.GetHashCode () ^ Duration.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
