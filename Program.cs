using System;
using System.Collections.Generic;

namespace LinkedListTraining
{
	class Program
	{
    static void Main(string[] args)
    {
      // Define some strings that represent song names
      string[] songs =
      {
        "Shout", "Satisfaction", "Help!",
        "Stairway to Heaven", "Come Sail Away",
        "All Night Long", "Right Here Right Now"
      };

      // TODO: Create a LinkedList that holds strings
      LinkedList<string> myList = new LinkedList<string>(songs);


      // TODO: Items can be added at the front or back of the list
      myList.AddFirst("Africa");
      myList.AddLast("The Twist");

			// TODO: Like other collections, a LinkedList can be iterated
			foreach (string item in myList)
			{
        Console.WriteLine(item);
			}

      Console.WriteLine();

      // TODO: First and Last properties return LinkedListNodes
      LinkedListNode<string> first = myList.First;
      LinkedListNode<string> last = myList.Last;
      Console.WriteLine(first.Value);
      Console.WriteLine(last.Value);
      Console.WriteLine();

      // TODO: Items can be added or removed relative to an existing item
      myList.AddAfter(first, "Here comes the sun");

      foreach (string item in myList)
      {
        Console.WriteLine(item);
      }

      Console.WriteLine();

      // TODO: Search for items in the list with Contains and Find
      Console.WriteLine($"Contains the song \"Satisfaction\" : {myList.Contains("Satisfaction")}");
      Console.WriteLine($"Find specific node in the linkedlinst called \"Help\" (returns node type): {myList.Find("Help!").Value}");
      Console.WriteLine();

      // TODO: The list can then be traversed with those properties
      Console.WriteLine(first.Next.Value);
      Console.WriteLine(last.Previous.Value);



    }
  }
}
