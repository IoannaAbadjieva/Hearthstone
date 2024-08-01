namespace Hearthstone.Tests.Correctness
{

	using NUnit.Framework;

	public class Test03
	{
		[TestCase]
		public void Draw_Should_Add_Card_Name_To_Deck()
		{
			//Arrange
			var card = new Card("Gnome the grudge", 10, 20, 5);
			var card2 = new Card("Best hearthstone card", 10, 15, 5);

			var board = new Board();

			//Act
			board.Draw(card);
			board.Draw(card2);

			bool result = board.Contains("Gnome the grudge") && board.Contains("Best hearthstone card");
			//Assert
			Assert.That(result, Is.EqualTo(true));

		}
	}
}
