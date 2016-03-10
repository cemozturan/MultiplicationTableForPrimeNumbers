namespace Core.MultiplicationTable
{
	public class TableRowCreator
	{
		public string CreateHeaderRow(int[] primeNumbers)
		{
			var row = CreateFactorCell(null);
			row += CreateMultiplicationResultCells(primeNumbers);
            return row;
		}

		public string CreateRow(int[] primeNumbers, int factor)
		{
			var row = CreateFactorCell(factor);
			row += CreateMultiplicationResultCells(primeNumbers);
			return row;
		}

		private string CreateFactorCell(int? factor)
		{
			return "| " + (factor.HasValue ? factor.ToString() : " ") + " |";
		}

		private string CreateMultiplicationResultCell(int number)
		{
			return " " + number + " |";
		}

		private string CreateMultiplicationResultCells(int[] primeNumbers)
		{
			var cells = "";
			for (var i = 0; i < primeNumbers.Length; i++)
			{
				cells += CreateMultiplicationResultCell(primeNumbers[i]);
			}
			return cells;
		}
	}
}
