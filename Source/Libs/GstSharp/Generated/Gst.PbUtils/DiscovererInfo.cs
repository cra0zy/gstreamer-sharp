// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.PbUtils {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class DiscovererInfo : GLib.Object {

		public DiscovererInfo (IntPtr raw) : base(raw) {}

		protected DiscovererInfo() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_discoverer_info_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_discoverer_info_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_discoverer_info_from_variant(IntPtr variant);

		public static Gst.PbUtils.DiscovererInfo FromVariant(GLib.Variant variant) {
			IntPtr raw_ret = gst_discoverer_info_from_variant(variant == null ? IntPtr.Zero : variant.Handle);
			Gst.PbUtils.DiscovererInfo ret = GLib.Object.GetObject(raw_ret, true) as Gst.PbUtils.DiscovererInfo;
			return ret;
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_discoverer_info_copy(IntPtr raw);

		public Gst.PbUtils.DiscovererInfo Copy() {
			IntPtr raw_ret = gst_discoverer_info_copy(Handle);
			Gst.PbUtils.DiscovererInfo ret = GLib.Object.GetObject(raw_ret, true) as Gst.PbUtils.DiscovererInfo;
			return ret;
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_discoverer_info_get_audio_streams(IntPtr raw);

		public Gst.PbUtils.DiscovererStreamInfo[] AudioStreams { 
			get {
				IntPtr raw_ret = gst_discoverer_info_get_audio_streams(Handle);
				Gst.PbUtils.DiscovererStreamInfo[] ret = (Gst.PbUtils.DiscovererStreamInfo[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(Gst.PbUtils.DiscovererStreamInfo));
				return ret;
			}
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_discoverer_info_get_container_streams(IntPtr raw);

		public Gst.PbUtils.DiscovererStreamInfo[] ContainerStreams { 
			get {
				IntPtr raw_ret = gst_discoverer_info_get_container_streams(Handle);
				Gst.PbUtils.DiscovererStreamInfo[] ret = (Gst.PbUtils.DiscovererStreamInfo[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(Gst.PbUtils.DiscovererStreamInfo));
				return ret;
			}
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern ulong gst_discoverer_info_get_duration(IntPtr raw);

		public ulong Duration { 
			get {
				ulong raw_ret = gst_discoverer_info_get_duration(Handle);
				ulong ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_discoverer_info_get_misc(IntPtr raw);

		[Obsolete]
		public Gst.Structure Misc { 
			get {
				IntPtr raw_ret = gst_discoverer_info_get_misc(Handle);
				Gst.Structure ret = raw_ret == IntPtr.Zero ? null : (Gst.Structure) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Structure), false);
				return ret;
			}
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_discoverer_info_get_missing_elements_installer_details(IntPtr raw);

		public string[] MissingElementsInstallerDetails { 
			get {
				IntPtr raw_ret = gst_discoverer_info_get_missing_elements_installer_details(Handle);
				string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, false);
				return ret;
			}
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_discoverer_info_get_result(IntPtr raw);

		public Gst.PbUtils.DiscovererResult Result { 
			get {
				int raw_ret = gst_discoverer_info_get_result(Handle);
				Gst.PbUtils.DiscovererResult ret = (Gst.PbUtils.DiscovererResult) raw_ret;
				return ret;
			}
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_discoverer_info_get_seekable(IntPtr raw);

		public bool Seekable { 
			get {
				bool raw_ret = gst_discoverer_info_get_seekable(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_discoverer_info_get_stream_info(IntPtr raw);

		public Gst.PbUtils.DiscovererStreamInfo StreamInfo { 
			get {
				IntPtr raw_ret = gst_discoverer_info_get_stream_info(Handle);
				Gst.PbUtils.DiscovererStreamInfo ret = GLib.Object.GetObject(raw_ret, true) as Gst.PbUtils.DiscovererStreamInfo;
				return ret;
			}
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_discoverer_info_get_stream_list(IntPtr raw);

		public Gst.PbUtils.DiscovererStreamInfo[] StreamList { 
			get {
				IntPtr raw_ret = gst_discoverer_info_get_stream_list(Handle);
				Gst.PbUtils.DiscovererStreamInfo[] ret = (Gst.PbUtils.DiscovererStreamInfo[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(Gst.PbUtils.DiscovererStreamInfo));
				return ret;
			}
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_discoverer_info_get_streams(IntPtr raw, IntPtr streamtype);

		public Gst.PbUtils.DiscovererStreamInfo[] GetStreams(GLib.GType streamtype) {
			IntPtr raw_ret = gst_discoverer_info_get_streams(Handle, streamtype.Val);
			Gst.PbUtils.DiscovererStreamInfo[] ret = (Gst.PbUtils.DiscovererStreamInfo[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(Gst.PbUtils.DiscovererStreamInfo));
			return ret;
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_discoverer_info_get_subtitle_streams(IntPtr raw);

		public Gst.PbUtils.DiscovererStreamInfo[] SubtitleStreams { 
			get {
				IntPtr raw_ret = gst_discoverer_info_get_subtitle_streams(Handle);
				Gst.PbUtils.DiscovererStreamInfo[] ret = (Gst.PbUtils.DiscovererStreamInfo[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(Gst.PbUtils.DiscovererStreamInfo));
				return ret;
			}
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_discoverer_info_get_tags(IntPtr raw);

		public Gst.TagList Tags { 
			get {
				IntPtr raw_ret = gst_discoverer_info_get_tags(Handle);
				Gst.TagList ret = raw_ret == IntPtr.Zero ? null : (Gst.TagList) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.TagList), false);
				return ret;
			}
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_discoverer_info_get_toc(IntPtr raw);

		public Gst.Toc Toc { 
			get {
				IntPtr raw_ret = gst_discoverer_info_get_toc(Handle);
				Gst.Toc ret = Gst.Toc.New (raw_ret);
				return ret;
			}
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_discoverer_info_get_uri(IntPtr raw);

		public string Uri { 
			get {
				IntPtr raw_ret = gst_discoverer_info_get_uri(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_discoverer_info_get_video_streams(IntPtr raw);

		public Gst.PbUtils.DiscovererStreamInfo[] VideoStreams { 
			get {
				IntPtr raw_ret = gst_discoverer_info_get_video_streams(Handle);
				Gst.PbUtils.DiscovererStreamInfo[] ret = (Gst.PbUtils.DiscovererStreamInfo[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(Gst.PbUtils.DiscovererStreamInfo));
				return ret;
			}
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_discoverer_info_to_variant(IntPtr raw, int flags);

		public GLib.Variant ToVariant(Gst.PbUtils.DiscovererSerializeFlags flags) {
			IntPtr raw_ret = gst_discoverer_info_to_variant(Handle, (int) flags);
			GLib.Variant ret = new GLib.Variant(raw_ret);
			return ret;
		}


		static DiscovererInfo ()
		{
			GtkSharp.GstSharp.ObjectManager.Initialize ();
		}
#endregion
	}
}
