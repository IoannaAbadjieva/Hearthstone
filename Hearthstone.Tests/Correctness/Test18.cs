﻿namespace Hearthstone.Tests.Correctness
{
	using System.Linq;

	using NUnit.Framework;

	public class Test18
	{
		[TestCase]
		public void GetBestOfRange_Should_Have_Right_Count()
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

			var result = board.GetBestInRange(8, 15);

			//Assert
			Assert.That(result.Count(), Is.EqualTo(3));

		}
	}
}