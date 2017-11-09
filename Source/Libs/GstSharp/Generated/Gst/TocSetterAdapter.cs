// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class TocSetterAdapter : GLib.GInterfaceAdapter, Gst.ITocSetter {

		[StructLayout (LayoutKind.Sequential)]
		struct GstTocSetterInterface {
		}

		static GstTocSetterInterface iface;

		static TocSetterAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (TocSetterAdapter));
		}

		static void Initialize (IntPtr ptr, IntPtr data)
		{
		}

		GLib.Object implementor;

		public TocSetterAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public TocSetterAdapter (ITocSetterImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public TocSetterAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_toc_setter_get_type();

		private static GLib.GType _gtype = new GLib.GType (gst_toc_setter_get_type ());

		public static GLib.GType GType {
			get {
				return _gtype;
			}
		}

		public override GLib.GType GInterfaceGType {
			get {
				return _gtype;
			}
		}

		public override IntPtr Handle {
			get {
				return implementor.Handle;
			}
		}

		public IntPtr OwnedHandle {
			get {
				return implementor.OwnedHandle;
			}
		}

		public static ITocSetter GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static ITocSetter GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is ITocSetterImplementor)
				return new TocSetterAdapter (obj as ITocSetterImplementor);
			else if (obj as ITocSetter == null)
				return new TocSetterAdapter (obj.Handle);
			else
				return obj as ITocSetter;
		}

		public ITocSetterImplementor Implementor {
			get {
				return implementor as ITocSetterImplementor;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_toc_setter_get_toc(IntPtr raw);

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_toc_setter_set_toc(IntPtr raw, IntPtr value);

		public Gst.Toc Toc { 
			get {
				IntPtr raw_ret = gst_toc_setter_get_toc(Handle);
				Gst.Toc ret = Gst.Toc.New (raw_ret);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
				gst_toc_setter_set_toc(Handle, native_value);
				Marshal.FreeHGlobal (native_value);
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_toc_setter_reset(IntPtr raw);

		public void Reset() {
			gst_toc_setter_reset(Handle);
		}

#endregion
	}
}
