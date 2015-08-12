// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Epsara {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class DataBeam : GLib.Object {

		[Obsolete]
		protected DataBeam(GLib.GType gtype) : base(gtype) {}
		public DataBeam(IntPtr raw) : base(raw) {}

		protected DataBeam() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("inc-angle-phi")]
		public double IncAnglePhi {
			get {
				GLib.Value val = GetProperty ("inc-angle-phi");
				double ret = (double) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("inc-angle-phi", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("inc-angle-theta")]
		public double IncAngleTheta {
			get {
				GLib.Value val = GetProperty ("inc-angle-theta");
				double ret = (double) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("inc-angle-theta", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("pos-lateral-y")]
		public double PosLateralY {
			get {
				GLib.Value val = GetProperty ("pos-lateral-y");
				double ret = (double) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("pos-lateral-y", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("mass-no-inc-ion")]
		public int MassNoIncIon {
			get {
				GLib.Value val = GetProperty ("mass-no-inc-ion");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("mass-no-inc-ion", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("pos-lateral-x")]
		public double PosLateralX {
			get {
				GLib.Value val = GetProperty ("pos-lateral-x");
				double ret = (double) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("pos-lateral-x", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("ion-beam-dead-layer")]
		public Epsara.DataMaterial IonBeamDeadLayer {
			get {
				GLib.Value val = GetProperty ("ion-beam-dead-layer");
				Epsara.DataMaterial ret = (Epsara.DataMaterial) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("ion-beam-dead-layer", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("ion-count-rate")]
		public double IonCountRate {
			get {
				GLib.Value val = GetProperty ("ion-count-rate");
				double ret = (double) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("ion-count-rate", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("ion-energy")]
		public double IonEnergy {
			get {
				GLib.Value val = GetProperty ("ion-energy");
				double ret = (double) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("ion-energy", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("charge-state")]
		public int ChargeState {
			get {
				GLib.Value val = GetProperty ("charge-state");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("charge-state", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("atomic-mass-inc-ion")]
		public double AtomicMassIncIon {
			get {
				GLib.Value val = GetProperty ("atomic-mass-inc-ion");
				double ret = (double) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("atomic-mass-inc-ion", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("atomic-no-inc-ion")]
		public int AtomicNoIncIon {
			get {
				GLib.Value val = GetProperty ("atomic-no-inc-ion");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("atomic-no-inc-ion", val);
				val.Dispose ();
			}
		}

		[DllImport("libepsara-0.dll")]
		static extern IntPtr epsara_data_beam_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = epsara_data_beam_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
