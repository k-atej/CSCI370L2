using System;
using UnityEngine;

public class Give : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public string item;
    public Inventory inventory;

    public NPC recipient;

    public Inventory npcInv;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            Interact();
        }
        
    }

    void Interact() {
        if(recipient.name == "Coffee Shop Owner"){
          item = "Keys";
        }
        else{
           item = "Coffee";
        }
        if(inventory.HasItem(item)){
        inventory.RemoveItem(item);
        npcInv.AddItem(item);
        Debug.Log("Item Tranferred");
        }
    }
    
}
