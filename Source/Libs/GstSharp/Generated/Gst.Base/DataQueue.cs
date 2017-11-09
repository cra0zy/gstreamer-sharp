// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Base {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class DataQueue : GLib.Object {

		public DataQueue (IntPtr raw) : base(raw) {}

		protected DataQueue() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("current-level-bytes")]
		public uint CurrentLevelBytes {
			get {
				GLib.Value val = GetProperty ("current-level-bytes");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("current-level-time")]
		public ulong CurrentLevelTime {
			get {
				GLib.Value val = GetProperty ("current-level-time");
				ulong ret = (ulong) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("current-level-visible")]
		public uint CurrentLevelVisible {
			get {
				GLib.Value val = GetProperty ("current-level-visible");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Signal("empty")]
		public event System.EventHandler Empty {
			add {
				this.AddSignalHandler ("empty", value);
			}
			remove {
				this.RemoveSignalHandler ("empty", value);
			}
		}

		[GLib.Signal("full")]
		public event System.EventHandler Full {
			add {
				this.AddSignalHandler ("full", value);
			}
			remove {
				this.RemoveSignalHandler ("full", value);
			}
		}

		static EmptyNativeDelegate Empty_cb_delegate;
		static EmptyNativeDelegate EmptyVMCallback {
			get {
				if (Empty_cb_delegate == null)
					Empty_cb_delegate = new EmptyNativeDelegate (Empty_cb);
				return Empty_cb_delegate;
			}
		}

		static void OverrideEmpty (GLib.GType gtype)
		{
			OverrideEmpty (gtype, EmptyVMCallback);
		}

		static void OverrideEmpty (GLib.GType gtype, EmptyNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("empty"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void EmptyNativeDelegate (IntPtr inst);

		static void Empty_cb (IntPtr inst)
		{
			try {
				DataQueue __obj = GLib.Object.GetObject (inst, false) as DataQueue;
				__obj.OnEmpty ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Base.DataQueue), ConnectionMethod="OverrideEmpty")]
		protected virtual void OnEmpty ()
		{
			InternalEmpty ();
		}

		private void InternalEmpty ()
		{
			EmptyNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("empty"));
				unmanaged = (EmptyNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(EmptyNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static FullNativeDelegate Full_cb_delegate;
		static FullNativeDelegate FullVMCallback {
			get {
				if (Full_cb_delegate == null)
					Full_cb_delegate = new FullNativeDelegate (Full_cb);
				return Full_cb_delegate;
			}
		}

		static void OverrideFull (GLib.GType gtype)
		{
			OverrideFull (gtype, FullVMCallback);
		}

		static void OverrideFull (GLib.GType gtype, FullNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("full"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void FullNativeDelegate (IntPtr inst);

		static void Full_cb (IntPtr inst)
		{
			try {
				DataQueue __obj = GLib.Object.GetObject (inst, false) as DataQueue;
				__obj.OnFull ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Base.DataQueue), ConnectionMethod="OverrideFull")]
		protected virtual void OnFull ()
		{
			InternalFull ();
		}

		private void InternalFull ()
		{
			FullNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("full"));
				unmanaged = (FullNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(FullNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("empty"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // empty
							, null
							, "full"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("full"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // full
							, "empty"
							, "_gst_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _gst_reserved
							, "full"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("libgstbase-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_data_queue_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_data_queue_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		static DataQueue ()
		{
			GtkSharp.GstSharp.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GLib.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, "_gst_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _gst_reserved
							, "priv"
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
