using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GLib;
using Epsara;

namespace EpsaraSharpXmpl
{
    class Program
    {
        static void Main(string[] args)
        {
            DataVector new_vector = new DataVector(20);
            Console.WriteLine("new_vector.Size = {0}", new_vector.Size);

            new_vector[2] = 10.21;
            Console.WriteLine("new_vector[2] = {0}", new_vector[2]);

            new_vector.Size = 30;
            Console.WriteLine("new_vector.Size = {0}", new_vector.Size);

            new_vector[31] = 30;
            Console.WriteLine("new_vector.Size = {0}", new_vector.Size);
            Console.WriteLine("new_vector[2] = {0}", new_vector[2]);
            Console.WriteLine("new_vector[31] = {0}", new_vector[31]);

            DataSimpleMaterial gallium = new DataSimpleMaterial();
            DataSimpleMaterial nitrogen = new DataSimpleMaterial();
            DataSimpleMeasurement a_simple_measurement = new DataSimpleMeasurement();
            DataMatrix result_matrix;

            a_simple_measurement.AtomicNoIncIon = 2;
            a_simple_measurement.MassNoIncIon = 4;
            a_simple_measurement.IonEnergy = 2237.0;
            a_simple_measurement.IonFluence = 2.2857e13;
            a_simple_measurement.SolidAngle = 4.2;
            a_simple_measurement.IncAngleTheta = 0.0;
            a_simple_measurement.IncAnglePhi = 0.0;
            a_simple_measurement.OutAngleTheta = 0.0;
            a_simple_measurement.OutAnglePhi = 10.0;
            a_simple_measurement.ChannelMin= 0;
            a_simple_measurement.ChannelMax = 511;
            a_simple_measurement.CaliEnergyPerChannel = 5.37207;
            a_simple_measurement.CaliEnergyPerChannelSquare = -0.000413111;
            a_simple_measurement.CaliEnergyPerChannelCube = 0.0;
            a_simple_measurement.CaliEnergyOffset = -12.1717;

            gallium.AtomicNoInitialTarget = 31;
            gallium.MassNoInitialTarget = 69;
            gallium.LayerBegin = 0.0;
            gallium.LayerEnd = 200000.0;
            gallium.AtomicDensity = 2.1937e22;
            gallium.QValue = 0.0;
            gallium.AtomicNoRemainTarget = 31;
            gallium.MassNoRemainTarget = 69;
            gallium.AtomicNoDetIon = 2;
            gallium.MassNoDetIon = 4;
            gallium.RbsActive = true;
            gallium.NraActive = false;

            nitrogen.AtomicNoInitialTarget = 7;
            nitrogen.MassNoInitialTarget = 14;
            nitrogen.LayerBegin = 0.0;
            nitrogen.LayerEnd = 200000.0;
            nitrogen.AtomicDensity = 2.1937e22;
            nitrogen.QValue = 0.0;
            nitrogen.AtomicNoRemainTarget = 7;
            nitrogen.MassNoRemainTarget = 14;
            nitrogen.AtomicNoDetIon = 2;
            nitrogen.MassNoDetIon = 4;
            nitrogen.RbsActive = true;
            nitrogen.NraActive = false;

            a_simple_measurement.Add((GLib.Object)gallium);
            a_simple_measurement.Add((GLib.Object)nitrogen);
            a_simple_measurement.Calculate();

            result_matrix = a_simple_measurement.CalcedSpectrum;

            Console.WriteLine("Channel Yield");
            for (int i = 0; i < result_matrix.Columns; i++)
            {
                Console.WriteLine("{0}    {1}", result_matrix[ 0, i], result_matrix[2, i]);
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
