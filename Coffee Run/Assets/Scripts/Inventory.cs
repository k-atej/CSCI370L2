using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    public GameObject player;
    

    List<string> inventory = new List<string>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddItem(string itemName){
        inventory.Add(itemName);
        Debug.Log("adding: " + itemName);

    }

    public void RemoveItem(string itemName){
        inventory.Remove(itemName);

    }

    public List<string> checkInventory(){
        return inventory;
    }
}
