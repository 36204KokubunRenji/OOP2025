using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    public class FeetConverter {

        static double FeetMeter(double meter) {
            return meter / 0.3048;
        }

        static double MeterFeet(double feet) {
            return feet * 0.3048;
        }

    }
}