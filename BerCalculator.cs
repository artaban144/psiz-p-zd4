using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace psiz_p_zd4
{
	public class BerCalculator
	{
		private string filePath1;

		private string filePath2;
		public BerCalculator(string _filePath1, string _filePath2)
		{
			filePath1 = _filePath1;
			filePath2 = _filePath2;
		}

		public BerResult CalculateBer()
		{
			BerResult result = new BerResult();

			result.StartCalculation();

			using (StreamReader fileOne = new StreamReader(this.filePath1))
			using (StreamReader fileTwo = new StreamReader(this.filePath2))
			{
				while (fileOne.Peek() >= 0)
				{
					byte charFromFirstFile = (byte)fileOne.Read();
					byte charFromSecondFile = (byte)fileTwo.Read();

					result.ErrorBits += getHammingDistance(charFromFirstFile, charFromSecondFile);
					result.TotalNumberOfBits += 8;
				}
			}

			result.Result = (float)result.ErrorBits / (float)result.TotalNumberOfBits;
			result.StopCalculation();

			return result;
		}

		private int getHammingDistance(int charNumber1, int charNumber2)
		{
			int x = charNumber1 ^ charNumber2;
			int result = 0;

			while (x > 0)
			{
				result += x & 1;
				x >>= 1;
			}

			return result;
		}
	}
}
