using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson35_3
{
    internal class Converter
    {
        private double current;

        public Converter(double current)
        {
            this.current = current;
        }
        public double toSm()
        {
            return 0.1*current;
        }
        public double toDm()
        {
        return 0.01*current;
        }
        public double toMetr()
        {
            return 0.001 * current;
        }
        public double toKm() => 0.0001 * current;
        public double toKelvin() => current + 273.15;
        public double toFarengait() => 1.8 * current + 32;
        public double toMmRtSt() => current * 0.0075;
        public double toBar() => current * 0.00001;
        public double toAtm() => current * 0.00001;

    }
}
