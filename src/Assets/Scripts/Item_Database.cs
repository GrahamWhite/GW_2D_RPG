using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Item_Database :MonoBehaviour
{
    public List<Item> items = new List<Item>();

    private void Awake()
    {
        BuildDatabase();
    }
   
    public void BuildDatabase()
    {
        items = new List<Item>(){
                new Item(0, "Diamond Sword", "A hard expensive sword", new Dictionary<string, int>

                {
                    {"Power",15 },
                    {"Defence",10 }
                }),
                 new Item(1, "Diamond Ore", "A hard expensive ore", new Dictionary<string, int>

                {
                    {"Value",400 }
                }),
                  new Item(1, "Coin", "$1", new Dictionary<string, int>

                {
                    {"Value",1 }
                })

        };        
    }

    public Item GetItem(string itemName)
    {
        Item i= items.Find(item => item.title == itemName);
        return i;
    }

    public Item GetItem(int id)
    {
        return items.Find(item => item.id == id);
    }

    public List<Item> GetItemList()
    {
        return items;
    }

   


}
