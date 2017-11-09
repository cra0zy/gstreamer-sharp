// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class DeviceProviderFactory : Gst.PluginFeature {

		public DeviceProviderFactory (IntPtr raw) : base(raw) {}

		protected DeviceProviderFactory() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (Gst.PluginFeature.class_abi.Fields);

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_device_provider_factory_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_device_provider_factory_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_device_provider_factory_find(IntPtr name);

		public static Gst.DeviceProviderFactory Find(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = gst_device_provider_factory_find(native_name);
			Gst.DeviceProviderFactory ret = GLib.Object.GetObject(raw_ret, true) as Gst.DeviceProviderFactory;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_device_provider_factory_get_by_name(IntPtr factoryname);

		public static Gst.DeviceProvider GetByName(string factoryname) {
			IntPtr native_factoryname = GLib.Marshaller.StringToPtrGStrdup (factoryname);
			IntPtr raw_ret = gst_device_provider_factory_get_by_name(native_factoryname);
			Gst.DeviceProvider ret = GLib.Object.GetObject(raw_ret, true) as Gst.DeviceProvider;
			GLib.Marshaller.Free (native_factoryname);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_device_provider_factory_list_get_device_providers(int minrank);

		public static Gst.DeviceProviderFactory[] ListGetDeviceProviders(Gst.Rank minrank) {
			IntPtr raw_ret = gst_device_provider_factory_list_get_device_providers((int) minrank);
			Gst.DeviceProviderFactory[] ret = (Gst.DeviceProviderFactory[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(Gst.DeviceProviderFactory));
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_device_provider_factory_get(IntPtr raw);

		public Gst.DeviceProvider Get() {
			IntPtr raw_ret = gst_device_provider_factory_get(Handle);
			Gst.DeviceProvider ret = GLib.Object.GetObject(raw_ret, true) as Gst.DeviceProvider;
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_device_provider_factory_get_device_provider_type(IntPtr raw);

		public GLib.GType DeviceProviderType { 
			get {
				IntPtr raw_ret = gst_device_provider_factory_get_device_provider_type(Handle);
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_device_provider_factory_get_metadata(IntPtr raw, IntPtr key);

		public string GetMetadata(string key) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr raw_ret = gst_device_provider_factory_get_metadata(Handle, native_key);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_device_provider_factory_get_metadata_keys(IntPtr raw);

		public string[] MetadataKeys { 
			get {
				IntPtr raw_ret = gst_device_provider_factory_get_metadata_keys(Handle);
				string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, true);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_device_provider_factory_has_classes(IntPtr raw, IntPtr classes);

		public bool HasClasses(string classes) {
			IntPtr native_classes = GLib.Marshaller.StringToPtrGStrdup (classes);
			bool raw_ret = gst_device_provider_factory_has_classes(Handle, native_classes);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_classes);
			return ret;
		}

		public bool HasClasses() {
			return HasClasses (null);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_device_provider_factory_has_classesv(IntPtr raw, IntPtr[] classes);

		public bool HasClassesv(string[] classes) {
			int cnt_classes = classes == null ? 0 : classes.Length;
			IntPtr[] native_classes = new IntPtr [cnt_classes + 1];
			for (int i = 0; i < cnt_classes; i++)
				native_classes [i] = GLib.Marshaller.StringToPtrGStrdup (classes[i]);
			native_classes [cnt_classes] = IntPtr.Zero;
			bool raw_ret = gst_device_provider_factory_has_classesv(Handle, native_classes);
			bool ret = raw_ret;
			for (int i = 0; i < native_classes.Length - 1; i++) {
				classes [i] = GLib.Marshaller.Utf8PtrToString (native_classes[i]);
				GLib.Marshaller.Free (native_classes[i]);
			}
			return ret;
		}

		public bool HasClassesv() {
			return HasClassesv (null);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (Gst.PluginFeature.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
