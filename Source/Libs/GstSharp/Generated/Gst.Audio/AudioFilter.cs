// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Audio {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class AudioFilter : Gst.Base.BaseTransform {

		protected AudioFilter (IntPtr raw) : base(raw) {}

		protected AudioFilter() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		public Gst.Audio.AudioInfo Info {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("info"));
					return (*raw_ptr) == IntPtr.Zero ? null : (Gst.Audio.AudioInfo) GLib.Opaque.GetOpaque ((*raw_ptr), typeof (Gst.Audio.AudioInfo), false);
				}
			}
		}

		static SetupNativeDelegate Setup_cb_delegate;
		static SetupNativeDelegate SetupVMCallback {
			get {
				if (Setup_cb_delegate == null)
					Setup_cb_delegate = new SetupNativeDelegate (Setup_cb);
				return Setup_cb_delegate;
			}
		}

		static void OverrideSetup (GLib.GType gtype)
		{
			OverrideSetup (gtype, SetupVMCallback);
		}

		static void OverrideSetup (GLib.GType gtype, SetupNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("setup"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool SetupNativeDelegate (IntPtr inst, IntPtr info);

		static bool Setup_cb (IntPtr inst, IntPtr info)
		{
			try {
				AudioFilter __obj = GLib.Object.GetObject (inst, false) as AudioFilter;
				bool __result;
				__result = __obj.OnSetup (info == IntPtr.Zero ? null : (Gst.Audio.AudioInfo) GLib.Opaque.GetOpaque (info, typeof (Gst.Audio.AudioInfo), false));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Audio.AudioFilter), ConnectionMethod="OverrideSetup")]
		protected virtual bool OnSetup (Gst.Audio.AudioInfo info)
		{
			return InternalSetup (info);
		}

		private bool InternalSetup (Gst.Audio.AudioInfo info)
		{
			SetupNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("setup"));
				unmanaged = (SetupNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(SetupNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle, info == null ? IntPtr.Zero : info.Handle);
			return __result;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("setup"
							, Gst.Base.BaseTransform.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // setup
							, null
							, "_gst_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _gst_reserved
							, "setup"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("libgstaudio-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_audio_filter_class_add_pad_templates(IntPtr allowed_caps);

		public static void AddAudioPadTemplate(Gst.Caps allowed_caps) {
			gst_audio_filter_class_add_pad_templates(allowed_caps == null ? IntPtr.Zero : allowed_caps.Handle);
		}

		[DllImport("libgstaudio-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_audio_filter_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_audio_filter_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		static AudioFilter ()
		{
			GtkSharp.GstSharp.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("info"
							, Gst.Base.BaseTransform.abi_info.Fields
							, Gst.Audio.AudioInfo.abi_info.Size // info
							, null
							, "_gst_reserved"
							, Gst.Audio.AudioInfo.abi_info.Align
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _gst_reserved
							, "info"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
