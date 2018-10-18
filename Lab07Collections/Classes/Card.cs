using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07Collections
{
  public class Card
  {
    /// <summary>
    /// constructor method with the defaut properties set
    /// </summary>
    public Suit Suit { get; set; }
    public Face Value { get; set; }
    public Card(Suit suitValue, Face faceValue)
    {
      Suit = suitValue;
      Value = faceValue;
    }
    /// <summary>
    /// describes the card
    /// </summary>
    /// <returns></returns>
    public string ShowValue()
    {
      return ($"{Value} of {Suit}");
    }
  }
  /// <summary>
  /// enum for the Suit property
  /// </summary>
  public enum Suit
  {
    Spades,
    Clubs,
    Diamonds,
    Hearts
  }
  /// <summary>
  /// enum for the value property
  /// </summary>
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
