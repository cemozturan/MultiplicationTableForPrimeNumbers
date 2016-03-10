namespace Core.MultiplicationTable
{
	public class TableRowCreator
	{
		public string CreateHeaderRow(int[] primeNumbers)
		{
			var row = CreateFactorCell(null);
			for (var i = 0; i < primeNumbers.Length; i++)
			{
				row += CreateNonFirstColumnCell(primeNumbers[i]);
			}
            return row;
		}

		public string CreateRow(int[] primeNumbers, int factor)
		{
			var row = CreateFactorCell(factor);
			row += CreateNonFirstColumnCells(primeNumbers, factor);
			return row;
		}

		/// <summary>
		/// These are the cells that appear in the first column.
		/// </summary>
		private string CreateFactorCell(int? factor)
		{
			return "| " + (factor.HasValue ? factor.ToString() : " ") + " |";
		}

		/// <summary>
		/// These are the cells that form all the columns but the first one.
		/// </summary>
		private string CreateNonFirstColumnCell(int number)
		{
			return " " + number + " |";
		}

		private string CreateNonFirstColumnCells(int[] primeNumbers, int factor)
		{
			var cells = "";
			for (var i = 0; i < primeNumbers.Length; i++)
			{
				cells += CreateNonFirstColumnCell(primeNumbers[i]*factor);
			}
			return cells;
		}
	}
}
