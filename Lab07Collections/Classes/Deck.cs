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
    /// <summary>
    /// adds object to the collection
    /// </summary>
    /// <param name="card">object to be added</param>
    public void Add(T card)
    {
      if (count == cards.Length)
      {
        Array.Resize(ref cards, cards.Length * 2);
      }
      cards[count++] = card;
    }
    /// <summary>
    /// removes the object specified. must be the exact same object
    /// it's not comparing the values
    /// </summary>
    /// <param name="card"></param>
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
    /// <summary>
    /// makes new deck, only adds in cards with the same suit specified
    /// </summary>
    /// <param name="suit">the filter value, only cards with the same suit will be return in the new deck</param>
    /// <returns></returns>
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
    /// <summary>
    /// for foreach, not including the other GetEnumerator because no legacy code here
    /// </summary>
    /// <returns></returns>
    public IEnumerator GetEnumerator()
    {
      for (int i = 0; i < count; i++)
      {
        yield return cards[i];
      }
    }
  }
}
