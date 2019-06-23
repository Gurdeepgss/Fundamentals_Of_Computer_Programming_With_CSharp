using System;

namespace AllCards_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All cards from deck of 52 cards");

			/*
			 * Clubs
			 * Diamonds
			 * Hearts
			 * Spades
			 *
			 * 11 Jack
			 * 12 Queen
			 * 13 King
			 * 1 Ace
			 */
			 string ofClubs = "of Clubs";
			 string ofHearts = "of Hearts";
			 string ofSpades = "of Spades";
			 string ofDiamonds = "of Diamonds";

			 string jack = "Jack";
			 string queen = "Queen";
			 string king = "King";
			 string ace = "Ace";

			Console.WriteLine($" {ace} {ofClubs}");	 
			 for(int index = 2; index <= 10; index++)
			 {
				 Console.WriteLine($" {index} {ofClubs}.");
			 }
			Console.WriteLine($" {jack} {ofClubs}");	 
			Console.WriteLine($" {queen} {ofClubs}");	 
			Console.WriteLine($" {king} {ofClubs}");	 
			Console.WriteLine();

			Console.WriteLine($" {ace} {ofHearts}");	 
			 for(int index = 2; index <= 10; index++)
			 {
				 Console.WriteLine($" {index} {ofHearts}.");
			 }
			Console.WriteLine($" {jack} {ofHearts}");	 
			Console.WriteLine($" {queen} {ofHearts}");	 
			Console.WriteLine($" {king} {ofHearts}");	 
			Console.WriteLine();

			Console.WriteLine($" {ace} {ofSpades}");	 
			 for(int index = 2; index <= 10; index++)
			 {
				 Console.WriteLine($" {index} {ofSpades}.");
			 }
			 
			Console.WriteLine($" {jack} {ofSpades}");	 
			Console.WriteLine($" {queen} {ofSpades}");	 
			Console.WriteLine($" {king} {ofSpades}");	 
			Console.WriteLine();

			Console.WriteLine($" {ace} {ofDiamonds}");	 
			 for(int index = 2; index <= 10; index++)
			 {
				 Console.WriteLine($" {index} {ofDiamonds}.");
			 }
			Console.WriteLine($" {jack} {ofDiamonds}");	 
			Console.WriteLine($" {queen} {ofDiamonds}");	 
			Console.WriteLine($" {king} {ofDiamonds}");	 
			Console.WriteLine();

			/*
			 * string two = "Two";
			 * string three = "Three";
			 * string four = "Four";
			 * string five = "Five";
			 * string six = "Six";
			 * string seven = "Seven";
			 * string eight = "Eight";
			 * string nine = "Nine";
			 * string ten = "Ten";
			 */
        }
    }
}
