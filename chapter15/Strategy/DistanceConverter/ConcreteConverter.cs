using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    public class MeterConverter : ConverterBase {
        protected override double Ratio => 1;
        public override string UnitName => "メートル";

        public override bool IsMyUnit(string name) =>
            name.ToLower() == "メートル" || name == UnitName;
    }
    public class FeetConverter : ConverterBase {
        protected override double Ratio => 0.3048;
        public override string UnitName => "フィート";

        public override bool IsMyUnit(string name) =>
               name.ToLower() == "フィート" || name == UnitName;
    }
    public class InchConverter : ConverterBase {
        protected override double Ratio => 0.0254;
        public override string UnitName => "インチ";

        public override bool IsMyUnit(string name) =>
               name.ToLower() == "インチ" || name == UnitName;
    }
    public class YardConverter : ConverterBase {
        protected override double Ratio => 0.9144;
        public override string UnitName => "ヤード";

        public override bool IsMyUnit(string name) =>
               name.ToLower() == "ヤード" || name == UnitName;
    }
    public class MileConverter : ConverterBase {
        protected override double Ratio => 1609.34;
        public override string UnitName => "マイル";

        public override bool IsMyUnit(string name) =>
            name.ToLower() == "マイル" || name == UnitName;
    }
    public class KiloMeterConverter : ConverterBase {
        protected override double Ratio => 1000;
        public override string UnitName => "キロメートル";

        public override bool IsMyUnit(string name) =>
            name.ToLower() == "キロメートル" || name == UnitName;
    }
}
