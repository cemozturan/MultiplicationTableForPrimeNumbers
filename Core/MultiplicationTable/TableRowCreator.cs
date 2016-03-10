namespace Core.MultiplicationTable
{
	public class TableRowCreator
	{
		public string CreateRow(int[] primeNumbers, int? factor)
		{
			var row = CreateFactorCell(factor);
			for (var i = 0; i < primeNumbers.Length; i++)
			{
				row += CreateMultiplicationCell(primeNumbers[i]);
			}

			return row;
		}

		private string CreateFactorCell(int? factor)
		{
			return "| " + (factor.HasValue ? factor.ToString() : " ") + " |";
		}

		private string CreateMultiplicationCell(int number)
		{
			return " " + number + " |";
		}
	}
}
