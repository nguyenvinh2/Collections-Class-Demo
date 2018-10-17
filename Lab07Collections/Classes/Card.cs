using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07Collections
{
  public class Card
  {
    public Suit Suit { get; set; }
    public Face Value { get; set; }
    public Card(Suit suitValue, Face faceValue)
    {
      Suit = suitValue;
      Value = faceValue;
    }

    public Card()
    {
      Random suitNumberGenerator = new Random();
      Random valueNumberGenerator = new Random();
    }

    public string ShowValue()
    {
      return ($"{Value} of {Suit}");
    }
  }
  public enum Suit
  {
    Spades,
    Clubs,
    Diamonds,
    Hearts
  }
  public enum Face
  {
    Ace,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King
  }
}
