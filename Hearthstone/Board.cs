namespace Hearthstone
{
	using System;
	using System.Collections.Generic;
	public class Board : IBoard
	{
 		//Check if board contains a given card
		public bool Contains(string name)
		{
			throw new NotImplementedException();
		}

		public int Count()
		{
			throw new NotImplementedException();
		}

		public void Draw(Card card)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Card> GetBestInRange(int start, int end)
		{
			throw new NotImplementedException();
		}

		public void Heal(int health)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Card> ListCardsByPrefix(string prefix)
		{
			throw new NotImplementedException();
		}

		public void Play(string attackerCardName, string attackedCardName)
		{
			throw new NotImplementedException();
		}

		public void Remove(string name)
		{
			throw new NotImplementedException();
		}

		public void RemoveDeath()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Card> SearchByLevel(int level)
		{
			throw new NotImplementedException();
		}
	}
}
