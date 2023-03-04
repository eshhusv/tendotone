using ninedotone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tendotone
{
    internal class EuroToRub : BillCounter
    {
        public EuroToRub(int oneBillCount, int twoBillCount, int fiveBillCount, int tenBillCount, int fiftyBillCount, int hundredBillCount, int fiveHundredBillCount, int thousandBillCount, int fiveThousandBillCount) : base(oneBillCount, twoBillCount, fiveBillCount, tenBillCount, fiftyBillCount, hundredBillCount, fiveHundredBillCount, thousandBillCount, fiveThousandBillCount)
        {
        }
        public double getRubs()
        {
            return (base.getSum() / 80);
        }
    }
}
