// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp.EpsaraSharp {

	public class ObjectManager {

		static bool initialized = false;
		// Call this method from the appropriate module init function.
		public static void Initialize ()
		{
			if (initialized)
				return;

			initialized = true;
			GLib.GType.Register (epsara.EpsaraDataVector.GType, typeof (epsara.EpsaraDataVector));
		}
	}
}