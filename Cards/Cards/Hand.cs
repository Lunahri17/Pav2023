using System;
using System.Collections.Generic;

namespace Cards
{
    class Hand
	{
        public const int HandSize = 13;
        private List<PlayingCard> _cards = new List<PlayingCard>(HandSize);
        private int _playingCardCount = 0;

		public void AddCardToHand(PlayingCard cardDealt)
		{
            if (this._cards.Count >= HandSize)
            {
                throw new ArgumentException("Too many cards");
            }
            this._cards.Add(cardDealt);
        }

        public override string ToString()
		{
			string result = "";
			foreach (PlayingCard card in _cards)
			{
				result += card.ToString() + Environment.NewLine;
			}

			return result;
		}
	}
}