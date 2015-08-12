// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Epsara {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class DataMatrix : GLib.Object {

		[Obsolete]
		protected DataMatrix(GLib.GType gtype) : base(gtype) {}
		public DataMatrix(IntPtr raw) : base(raw) {}

		[DllImport("libepsara-0.dll")]
		static extern IntPtr epsara_data_matrix_new(int rows, int columns);

		public DataMatrix (int rows, int columns) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (DataMatrix)) {
				ArrayList vals = new ArrayList();
				ArrayList names = new ArrayList();
				names.Add ("rows");
				vals.Add (new GLib.Value (rows));
				names.Add ("columns");
				vals.Add (new GLib.Value (columns));
				CreateNativeObject ((string[])names.ToArray (typeof (string)), (GLib.Value[])vals.ToArray (typeof (GLib.Value)));
				return;
			}
			Raw = epsara_data_matrix_new(rows, columns);
		}

		[GLib.Property ("rows")]
		public int Rows {
			get {
				GLib.Value val = GetProperty ("rows");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("rows", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("columns")]
		public int Columns {
			get {
				GLib.Value val = GetProperty ("columns");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("columns", val);
				val.Dispose ();
			}
		}

		[DllImport("libepsara-0.dll")]
		static extern int epsara_data_matrix_mul_elements(IntPtr raw, IntPtr b);

		public int MulElements(Epsara.DataMatrix b) {
			int raw_ret = epsara_data_matrix_mul_elements(Handle, b == null ? IntPtr.Zero : b.Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libepsara-0.dll")]
		static extern void epsara_data_matrix_set_zero(IntPtr raw);

		public void SetZero() {
			epsara_data_matrix_set_zero(Handle);
		}

		[DllImport("libepsara-0.dll")]
		static extern void epsara_data_matrix_max_index(IntPtr raw, out int imax, out int jmax);

		public void MaxIndex(out int imax, out int jmax) {
			epsara_data_matrix_max_index(Handle, out imax, out jmax);
		}

		[DllImport("libepsara-0.dll")]
		static extern void epsara_data_matrix_minmax(IntPtr raw, out double min_out, out double max_out);

		public void Minmax(out double min_out, out double max_out) {
			epsara_data_matrix_minmax(Handle, out min_out, out max_out);
		}

		[DllImport("libepsara-0.dll")]
		static extern int epsara_data_matrix_add_constant(IntPtr raw, double x);

		public int AddConstant(double x) {
			int raw_ret = epsara_data_matrix_add_constant(Handle, x);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libepsara-0.dll")]
		static extern void epsara_data_matrix_set_identity(IntPtr raw);

		public void SetIdentity() {
			epsara_data_matrix_set_identity(Handle);
		}

		[DllImport("libepsara-0.dll")]
		static extern double epsara_data_matrix_max(IntPtr raw);

		public double Max() {
			double raw_ret = epsara_data_matrix_max(Handle);
			double ret = raw_ret;
			return ret;
		}

		[DllImport("libepsara-0.dll")]
		static extern int epsara_data_matrix_div_elements(IntPtr raw, IntPtr b);

		public int DivElements(Epsara.DataMatrix b) {
			int raw_ret = epsara_data_matrix_div_elements(Handle, b == null ? IntPtr.Zero : b.Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libepsara-0.dll")]
		static extern void epsara_data_matrix_minmax_index(IntPtr raw, out int imin, out int jmin, out int imax, out int jmax);

		public void MinmaxIndex(out int imin, out int jmin, out int imax, out int jmax) {
			epsara_data_matrix_minmax_index(Handle, out imin, out jmin, out imax, out jmax);
		}

		[DllImport("libepsara-0.dll")]
		static extern void epsara_data_matrix_set(IntPtr raw, int i, int j, double x);

		public void Set(int i, int j, double x) {
			epsara_data_matrix_set(Handle, i, j, x);
		}

		[DllImport("libepsara-0.dll")]
		static extern int epsara_data_matrix_swap(IntPtr raw, IntPtr w);

		public int Swap(Epsara.DataMatrix w) {
			int raw_ret = epsara_data_matrix_swap(Handle, w == null ? IntPtr.Zero : w.Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libepsara-0.dll")]
		static extern int epsara_data_matrix_add(IntPtr raw, IntPtr b);

		public int Add(Epsara.DataMatrix b) {
			int raw_ret = epsara_data_matrix_add(Handle, b == null ? IntPtr.Zero : b.Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libepsara-0.dll")]
		static extern void epsara_data_matrix_min_index(IntPtr raw, out int imin, out int jmin);

		public void MinIndex(out int imin, out int jmin) {
			epsara_data_matrix_min_index(Handle, out imin, out jmin);
		}

		[DllImport("libepsara-0.dll")]
		static extern void epsara_data_matrix_set_all(IntPtr raw, double x);

		public double All { 
			set {
				epsara_data_matrix_set_all(Handle, value);
			}
		}

		[DllImport("libepsara-0.dll")]
		static extern double epsara_data_matrix_get(IntPtr raw, int i, int j);

		public double Get(int i, int j) {
			double raw_ret = epsara_data_matrix_get(Handle, i, j);
			double ret = raw_ret;
			return ret;
		}

		[DllImport("libepsara-0.dll")]
		static extern double epsara_data_matrix_min(IntPtr raw);

		public double Min() {
			double raw_ret = epsara_data_matrix_min(Handle);
			double ret = raw_ret;
			return ret;
		}

		[DllImport("libepsara-0.dll")]
		static extern int epsara_data_matrix_scale(IntPtr raw, double x);

		public int Scale(double x) {
			int raw_ret = epsara_data_matrix_scale(Handle, x);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libepsara-0.dll")]
		static extern IntPtr epsara_data_matrix_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = epsara_data_matrix_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libepsara-0.dll")]
		static extern int epsara_data_matrix_sub(IntPtr raw, IntPtr b);

		public int Sub(Epsara.DataMatrix b) {
			int raw_ret = epsara_data_matrix_sub(Handle, b == null ? IntPtr.Zero : b.Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libepsara-0.dll")]
		static extern int epsara_data_matrix_copy(IntPtr raw, IntPtr src);

		public int Copy(Epsara.DataMatrix src) {
			int raw_ret = epsara_data_matrix_copy(Handle, src == null ? IntPtr.Zero : src.Handle);
			int ret = raw_ret;
			return ret;
		}

#endregion
	}
}