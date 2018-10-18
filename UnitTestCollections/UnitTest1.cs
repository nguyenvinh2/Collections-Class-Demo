using System;
using Xunit;
using System.Collections;
using System.Collections.Generic;
using Lab07Collections;
using Lab07Collections.Classes;

namespace UnitTestCollections
{
  public class UnitTest1
  {
    /// <summary>
    /// instantiates new blank deck
    /// instantiates new card
    /// adding one card
    /// count how many objects in the deck should only have 1
    /// </summary>
    [Fact]
    public void AddCardTest()
    {
      int count = 0;
      Deck<Card> DeckOfCards = new Deck<Card>();
      Card KingClubs = new Card(Suit.Clubs, Face.King);
      DeckOfCards.Add(KingClubs);
      foreach (Card item in DeckOfCards)
      {
        count++;
      }
      Assert.Equal(1, count);
    }
    /// <summary>
    /// since add method works and returns a 1 if adding a card
    /// removing a card should return count number back to 0;
    /// </summary>
    [Fact]
    public void RemoveCardTest()
    {
      int count = 0;
      Deck<Card> DeckOfCards = new Deck<Card>();
      Card KingClubs = new Card(Suit.Clubs, Face.King);
      DeckOfCards.Add(KingClubs);
      DeckOfCards.Remove(KingClubs);
      foreach (Card item in DeckOfCards)
      {
        count++;
      }
      Assert.Equal(0, count);
    }
    /// <summary>
    /// removing a card that does not exist should not change
    /// the deck. after adding the king of clubs, the count should be 1
    /// specifying a dummy card to be remove should still result in the
    /// number of cards in the deck = 1
    /// </summary>
    [Fact]
    public void RemoveCardNotExistTest()
    {
      int count = 0;
      Deck<Card> DeckOfCards = new Deck<Card>();
      Card KingClubs = new Card(Suit.Clubs, Face.King);
      DeckOfCards.Add(KingClubs);
      DeckOfCards.Remove(new Card(Suit.Diamonds, Face.Queen));
      foreach (Card item in DeckOfCards)
      {
        count++;
      }
      Assert.Equal(1, count);
    }
    /// <summary>
    /// retrieving the face of the card after instatiating it
    /// should be equal to what was originally specified
    /// </summary>
    /// <param name="expected">test value to equal to</param>
    /// <param name="input">suit of the card to be instatiated with</param>
    [Theory]
    [InlineData(Suit.Clubs, Suit.Clubs)]
    [InlineData(Suit.Spades, Suit.Spades)]
    [InlineData(Suit.Diamonds, Suit.Diamonds)]
    [InlineData(Suit.Hearts, Suit.Hearts)]
    public void GetCardSuitProperty(Suit expected, Suit input)
    {
      Card TestCard = new Card(input, Face.King);
      Assert.Equal(expected, TestCard.Suit);
    }
    /// <summary>
    /// Same as previous but for Values instead
    /// </summary>
    /// <param name="expected">test value expected</param>
    /// <param name="input">self explantory, the value of the card to be set</param>
    [Theory]
    [InlineData(Face.Ace, Face.Ace)]
    [InlineData(Face.Jack, Face.Jack)]
    [InlineData(Face.Queen, Face.Queen)]
    [InlineData(Face.King, Face.King)]
    public void GetCardValueProperty(Face expected, Face input)
    {
      Card TestCard = new Card(Suit.Hearts, input);
      Assert.Equal(expected, TestCard.Value);
    }
    /// <summary>
    /// changing properties of 7 of Hearts to clubs
    /// result should equal clubs
    /// </summary>
    [Fact]
    public void SetCardSuitProperty()
    {
      Card SevenHearts = new Card(Suit.Hearts, Face.Seven);
      SevenHearts.Suit = Suit.Clubs;
      Assert.Equal(Suit.Clubs, SevenHearts.Suit);
    }
    /// <summary>
    /// same thing but except for card values
    /// changed it from Seven to King
    /// result should equal King
    /// </summary>
    [Fact]
    public void SetCardValueProperty()
    {
      Card SevenHearts = new Card(Suit.Hearts, Face.Seven);
      SevenHearts.Value = Face.King;
      Assert.Equal(Face.King, SevenHearts.Value);
    }
  }
}
