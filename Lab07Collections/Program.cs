using System;
using System.Collections;
using System.Collections.Generic;
using Lab07Collections.Classes;

namespace Lab07Collections
{
  class Program
  {
    /// <summary>
    /// checking that every method in Deck works
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
      new Card(Suit.Hearts, Face.Queen);
      Deck<Card> DeckOfCards = new Deck<Card>();
      Console.WriteLine("Hello World!");
      Card KingClubs = new Card(Suit.Clubs, Face.King);
      DeckOfCards.Add(KingClubs);
      Console.WriteLine();
      Console.WriteLine("There is current one card in the deck");
      Console.WriteLine(KingClubs.ShowValue());
      Console.WriteLine();

      Console.WriteLine("Now there are Eleven");
      Console.WriteLine();

      Card QueenHearts = new Card(Suit.Hearts, Face.Queen);
      Card JackHearts = new Card(Suit.Hearts, Face.Jack);
      Card AceHearts = new Card(Suit.Hearts, Face.Ace);
      Card KingHearts = new Card(Suit.Hearts, Face.King);
      Card TwoClubs = new Card(Suit.Clubs, Face.Two);
      Card ThreeHearts = new Card(Suit.Hearts, Face.Three);
      Card FourDiamonds = new Card(Suit.Diamonds, Face.Four);
      Card FiveSpades = new Card(Suit.Spades, Face.Five);
      Card SixHearts = new Card(Suit.Hearts, Face.Six);
      Card SevenDiamonds = new Card(Suit.Diamonds, Face.Seven);

      DeckOfCards.Add(KingHearts);
      DeckOfCards.Add(QueenHearts);
      DeckOfCards.Add(JackHearts);
      DeckOfCards.Add(AceHearts);
      DeckOfCards.Add(TwoClubs);
      DeckOfCards.Add(ThreeHearts);
      DeckOfCards.Add(FourDiamonds);
      DeckOfCards.Add(FiveSpades);
      DeckOfCards.Add(SixHearts);
      DeckOfCards.Add(SevenDiamonds);

      foreach (Card card in DeckOfCards)
      {
        Console.WriteLine(card.ShowValue());
      }

      Console.WriteLine();

      Console.WriteLine($"Removing {SevenDiamonds.ShowValue()}");

      DeckOfCards.Remove(SevenDiamonds);
      Console.WriteLine();

      foreach (Card card in DeckOfCards)
      {
        Console.WriteLine(card.ShowValue());
      }
      Console.WriteLine();

      Console.WriteLine($"Removing {KingHearts.ShowValue()}, {QueenHearts.ShowValue()}, and {AceHearts.ShowValue()}");

      Console.WriteLine();

      DeckOfCards.Remove(KingHearts);
      DeckOfCards.Remove(QueenHearts);
      DeckOfCards.Remove(AceHearts);

      foreach (Card card in DeckOfCards)
      {
        Console.WriteLine(card.ShowValue());
      }

      Console.WriteLine();

      Console.WriteLine("Showing only Spades");

      Deck<Card> DeckOfSpades = DeckOfCards.ReturnSuit(Suit.Spades);

      Console.WriteLine();

      foreach (Card card in DeckOfSpades)
      {
        Console.WriteLine(card.ShowValue());
      }

      Console.WriteLine();

      Console.WriteLine("Showing only Clubs");

      Deck<Card> DeckOfClubs = DeckOfCards.ReturnSuit(Suit.Clubs);

      Console.WriteLine();

      foreach (Card card in DeckOfClubs)
      {
        Console.WriteLine(card.ShowValue());
      }

      Console.ReadKey();
    }
  }
}
