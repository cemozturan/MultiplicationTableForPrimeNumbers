using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.MultiplicationTable
{
	public class TableRowCreator
	{
		public string CreateRow(int[] primeNumbers, int? factor)
		{
			var row = "";
			if (!factor.HasValue)
			{
				row += CreateFactorCell();
				// This must be the header row
				for (var i = 0; i < primeNumbers.Length; i++)
				{
					row += CreateMultiplicationCell(primeNumbers[i]);
				}
			}
			return row;
		}

		private string CreateFactorCell()
		{
			return "|   |";
		}

		private string CreateMultiplicationCell(int number)
		{
			return " " + number + " |";
		}
	}
}
