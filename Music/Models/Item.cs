using System.Collections.Generic;

namespace Music.Models
{
  public class Item
  {
    public string Description { get; set; }
    public int Id { get; set; }
    private static List<Item> _instances = new List<Item> { };

    public Item(string description)
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Item Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public static void RemoveById(int id)
    {
      _instances.RemoveAt(id - 1);
    for (int index = 0; index < _instances.Count; index++)
      {
        _instances[index].Id = index + 1;
      }
    }  
  }
}
