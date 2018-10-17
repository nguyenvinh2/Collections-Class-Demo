using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab07Collections.Classes
{
  public class Deck<T> : IEnumerable
  {
    T[] cards = new T[10];
    int count = 0;

    public void Add(T card)
    {
      if (count == cards.Length)
      {
        Array.Resize(ref cards, cards.Length * 2);
      }
      cards[count++] = card;
    }

    public void Remove(T card)
    {
      int remover = 0;
      int tracker = 0;
      for (int i = 0; i < count; i++)
      {
        if (!card.Equals(cards[i]))
        {
          cards[tracker++] = cards[i];
        }
        else
        {
          remover++;
        }
      }
      Array.Resize(ref cards, cards.Length - remover);
      count = count - remover;
    }

    public Deck<Card> ReturnSuit(Suit suit)
    {
      Deck<Card> SameSuit = new Deck<Card>();

      for (int i = 0; i<count; i++)
      {
        Card card = (Card) Convert.ChangeType(cards[i], typeof(Card));
        if (card.Suit == suit)
        {
          SameSuit.Add(card);
        }
      }
      return SameSuit;
    }
    public IEnumerator GetEnumerator()
    {
      for (int i = 0; i < count; i++)
      {
        yield return cards[i];
      }
    }
  }
}
