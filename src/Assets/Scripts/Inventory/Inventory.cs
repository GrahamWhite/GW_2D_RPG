using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> characterItems = new List<Item>();
    public Item_Database itemDatabase;
    public UIInventory inventoryUI;
    // Start is called before the first frame update
    void Start()
    {
        itemDatabase.BuildDatabase();
        GiveItem("Diamond Sword");
        GiveItem("Diamond Ore");
        GiveItem("Coin");
        
    }

    public void GiveItem(string itemName)
    {
        Item itemToAdd = itemDatabase.GetItem(itemName);
        characterItems.Add(itemToAdd);
        inventoryUI.AddNewItem(itemToAdd);
        
        Debug.Log("Added Item: " + itemToAdd.title);
    }
    public void GiveItem(int id)
    {
        Item itemToAdd = itemDatabase.GetItem(id);
        characterItems.Add(itemToAdd);
        inventoryUI.AddNewItem(itemToAdd);
        Debug.Log("Added Item: " + itemToAdd.title);
    }


    public Item CheckForItem(int id)
    {
        return characterItems.Find(item => item.id == id);
    }

    public void RemoveItem(int id)
    {
        Item itemToRemove = CheckForItem(id);

        if(itemToRemove != null)
        {
            characterItems.Remove(itemToRemove);
            inventoryUI.RemoveItem(itemToRemove);
            Debug.Log("Item removed: " + itemToRemove.title);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
