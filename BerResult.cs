using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psiz_p_zd4
{
    public class BerResult
    {
        public BerResult()
        {
            Result = 0;
            TotalNumberOfBits = 0;
            ErrorBits = 0;
        }

        public float Result { get; set; }
        public double TotalNumberOfBits { get; set; }
        public double ErrorBits { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public void StartCalculation()
        {
            this.StartTime = DateTime.Now;
        }

        public void StopCalculation()
        {
            this.EndTime = DateTime.Now;
        }
    }
}
