// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Epsara {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class DataMaterial : GLib.Object {

		[Obsolete]
		protected DataMaterial(GLib.GType gtype) : base(gtype) {}
		public DataMaterial(IntPtr raw) : base(raw) {}

		protected DataMaterial() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("libepsara-0.dll")]
		static extern IntPtr epsara_data_material_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = epsara_data_material_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
