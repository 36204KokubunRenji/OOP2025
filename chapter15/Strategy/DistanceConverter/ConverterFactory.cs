using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    internal class ConverterFactory {
        private readonly static ConverterBase[] _converters = {
            new MeterConverter(),
            new FeetConverter(),
            new InchConverter(),
            new YardConverter(),
            new MileConverter(),
            new KiloMeterConverter()
        };

        public static ConverterBase? GetInstance(string name) =>
            _converters.FirstOrDefault(x => x.IsMyUnit(name));
    }
}
