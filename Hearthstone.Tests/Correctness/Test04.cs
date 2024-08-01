namespace Hearthstone.Tests.Correctness
{
	using Hearthstone;

	using NUnit.Framework;

	public class Test04
	{
		[TestCase]
		public void Contains_Should_Return_False_With_Invalid_Name()
		{
			//Arrange
			var card = new Card("Gnome the grudge", 10, 20, 5);
			var card2 = new Card("Best hearthstone card", 10, 15, 5);

			var board = new Board();

			//Act
			board.Draw(card);
			board.Draw(card2);

			bool actual = board.Contains("Invalid");
			//Assert
			Assert.IsFalse(actual);

		}
	}
}
