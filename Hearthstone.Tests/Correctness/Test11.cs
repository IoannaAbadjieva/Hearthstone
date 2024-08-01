﻿namespace Hearthstone.Tests.Correctness
{
	using NUnit.Framework;

	public class Test11
	{
		[TestCase]
		public void Play_Should_Decrease_Attacked_Card_Health()
		{
			//Arrange
			var card = new Card("Gnome the grudge", 10, 20, 5);
			var card2 = new Card("Magic Card", 10, 15, 5);
			var card3 = new Card("No magic Card", 6, 8, 3);
			var card4 = new Card("Simple card", 10, 8, 3);

			var board = new Board();

			//Act
			board.Draw(card);
			board.Draw(card2);
			board.Draw(card3);
			board.Draw(card4);

			board.Play("Gnome the grudge", "Magic Card");

			//Assert
			Assert.That(card2.Health, Is.EqualTo(10));

		}
	}
}