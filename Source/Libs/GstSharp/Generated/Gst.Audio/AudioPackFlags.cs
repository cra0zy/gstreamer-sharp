// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Audio {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.Audio.AudioPackFlagsGType))]
	public enum AudioPackFlags {

		None = 0,
		TruncateRange = 1,
	}

	internal class AudioPackFlagsGType {
		[DllImport ("libgstaudio-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_audio_pack_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_audio_pack_flags_get_type ());
			}
		}
	}
#endregion
}
