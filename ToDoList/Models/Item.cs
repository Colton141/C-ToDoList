using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    private string _description;
     private int _id;
    private static List<Item> _instances = new List<Item> {};


    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public Item (string description)
    {
      _description = description;
      _instances.Add(this);
      _id = _instances.Count;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public int GetId()
    {
      return _id;
    }
    public static Item Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public static void DestroyItem(int id)
    {
      _instances.RemoveAt(id - 1);
    }
  }
}
