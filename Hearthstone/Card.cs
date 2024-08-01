namespace Hearthstone
{
	public class Card
	{
		public Card(string name, int damage, int score, int level)
		{
			Name = name;
			Damage = damage;
			Score = score;
			Level = level;
			Health = 20;
		}
		public string Name { get; set; }

		public int Damage { get; set; }

		public int Score { get; set; }

		public int Health { get; set; }

		public int Level { get; set; }
	}
}