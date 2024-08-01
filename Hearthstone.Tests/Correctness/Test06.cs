namespace Hearthstone.Tests.Correctness
{
	using Hearthstone;

	using NUnit.Framework;

	public class Test06
	{
		[TestCase]
		public void Count_Should_Return_Zero_When_Deck_Has_No_Elements()
		{
			//Arrange

			var board = new Board();

			//Act;

			int count = board.Count();
			//Assert

			Assert.That(count, Is.EqualTo(0));

		}
	}
}
