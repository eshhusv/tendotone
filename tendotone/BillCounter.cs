using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ninedotone
{
    internal class BillCounter
    {
        private int sum;
        public int oneBillCount { get; set; }
        public int twoBillCount { get; set; }
        public int fiveBillCount { get; set; }
        public int tenBillCount { get; set; }
        public int fiftyBillCount { get; set; }
        public int hundredBillCount { get; set; }
        public int fiveHundredBillCount { get; set; }
        public int thousandBillCount { get; set; }
        public int fiveThousandBillCount { get; set; }

        public BillCounter(int oneBillCount, int twoBillCount, int fiveBillCount, int tenBillCount, int fiftyBillCount, int hundredBillCount, int fiveHundredBillCount, int thousandBillCount, int fiveThousandBillCount)
        {
            this.oneBillCount = oneBillCount;
            this.twoBillCount = twoBillCount;
            this.fiveBillCount = fiveBillCount;
            this.tenBillCount = tenBillCount;
            this.fiftyBillCount = fiftyBillCount;
            this.hundredBillCount = hundredBillCount;
            this.fiveHundredBillCount = fiveHundredBillCount;
            this.thousandBillCount = thousandBillCount;
            this.fiveThousandBillCount = fiveThousandBillCount;
        }

        public int getSum()
        {
            int i = 0;
            int oneBillCount = this.oneBillCount;
            if (oneBillCount > 0)
            {
                do
                {
                    sum++;
                    i++;
                } while (i < oneBillCount);
            }
            i = 0;
            int twoBillCount = this.twoBillCount;
            if (twoBillCount > 0)
            {
                do
                {
                    sum += 2;
                    i++;
                } while (i < twoBillCount);
            }
            i = 0;
            int fiveBillCount = this.fiftyBillCount;
            if (fiveBillCount > 0)
            {
                do
                {
                    sum += 5;
                    i++;
                } while (i < fiveBillCount);
            }
            i = 0;
            int tenBillCount = this.tenBillCount;
            if (tenBillCount > 0)
            {
                do
                {
                    sum += 10;
                    i++;
                } while (i < tenBillCount);
            }
            i = 0;
            int fiftyBillCount = this.fiftyBillCount;
            if (fiftyBillCount > 0)
            {
                do
                {
                    sum += 50;
                    i++;
                } while (i < fiftyBillCount);
            }
            i = 0;

            int hundredBillCount = this.hundredBillCount;
            if (hundredBillCount > 0)
            {
                do
                {
                    sum += 100;
                    i++;
                } while (i < hundredBillCount);
            }
            i = 0;
            int fiveHundredBillCount = this.fiveHundredBillCount;
            if (fiveHundredBillCount > 0)
            {
                do
                {
                    sum += 500;
                    i++;
                } while (i < fiveHundredBillCount);
            }
            i = 0;
            int thousandBillCount = this.thousandBillCount;
            if (thousandBillCount > 0)
            {
                do
                {
                    sum += 1000;
                    i++;
                } while (i < thousandBillCount);
            }
            i = 0;
            int fiveThousandBillCount = this.fiveThousandBillCount;
            if (fiveThousandBillCount > 0)
            {
                do
                {
                    sum += 5000;
                    i++;
                } while (i < fiveThousandBillCount);
            }
            i = 0;
            return sum * 80;
        }
    }
}