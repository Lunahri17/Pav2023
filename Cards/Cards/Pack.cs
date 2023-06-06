using System;
using System.Collections.Generic;

namespace Cards
{
	class Pack
	{
        public const int NumSuits = 4;
        public const int CardsPerSuit = 13;
        private Dictionary<Suit,List<PlayingCard>> _cardPack;
        private Random _randomCardSelector = new Random();

		public Pack()
		{
            this._cardPack = new Dictionary<Suit, List<PlayingCard>>(NumSuits);

            for (Suit suit = Suit.Clubs; suit <= Suit.Spades; suit++)
            {
                List<PlayingCard> cardsInSuit = new List<PlayingCard>(CardsPerSuit);
                for (Value value = Value.Two; value <= Value.Ace; value++)
                {
                    cardsInSuit.Add(new PlayingCard(suit, value));
                }
                this._cardPack.Add(suit, cardsInSuit);
            }
        }

        public PlayingCard DealCardFromPack()
        {
            Suit suit = (Suit)_randomCardSelector.Next(NumSuits);
            
            while (this.IsSuitEmpty(suit))
            {
                suit = (Suit)_randomCardSelector.Next(NumSuits);
            }

            Value value = (Value)_randomCardSelector.Next(CardsPerSuit);

            while (this.IsCardAlreadyDealt(suit, value))
            {
                value = (Value)_randomCardSelector.Next(CardsPerSuit);
            }

            List<PlayingCard> cardsInSuit = this._cardPack[suit];
            
            PlayingCard card = cardsInSuit.Find(c => c.CardValue == value);
            
            cardsInSuit.Remove(card);

            return card;
        }

        private bool IsSuitEmpty(Suit suit)
        {
            bool result = true;
            for (Value value = Value.Two; value <= Value.Ace; value++)
            {
                if (!IsCardAlreadyDealt(suit, value))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        private bool IsCardAlreadyDealt(Suit suit, Value value)
        {
            List<PlayingCard> cardsInSuit = this._cardPack[suit];
            return (!cardsInSuit.Exists(c => c.CardSuit == suit && c.CardValue == value));
        }
	}
}