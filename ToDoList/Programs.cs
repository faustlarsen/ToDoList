using System;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the To Do List.");
      Menu();
    }

    public static void Menu()
    {
      Console.WriteLine("Would you like to add or view an item to your list? Type add, view or done");
      string userInput = Console.ReadLine();
      if (userInput == "add")
      {
        AddNewItem();
      }
        else if (userInput == "view")
      {
        ListAllItems();
      }
        else if (userInput == "done")
      {
        Console.WriteLine("Good Bye");
      }
    }     
      
    public static void AddNewItem()
    {
      Console.WriteLine("What would you like to add?"); 
      string itemAdded = Console.ReadLine();
      Item newItem = new Item(itemAdded);
      ListAllItems();
    }
          
    public static void ListAllItems()
    {
      List<Item> fullList = Item.GetAll();
      { 
        Console.WriteLine("TO-DO list:");
        foreach (Item addedItem in fullList)
        {
          Console.WriteLine(addedItem.Description);
        }
        Menu();
      }
    }
  }
}
