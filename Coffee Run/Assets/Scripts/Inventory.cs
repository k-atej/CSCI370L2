using UnityEngine;
using System.Collections.Generic;
using TMPro;


public class Inventory : MonoBehaviour
{
    public GameObject player;
    

    List<string> inventory = new List<string>();

    [SerializeField] TextMeshProUGUI dialogueText;
    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] GameObject dialoguePanel;

    bool timer;
    int clock = 0;
    int delay = 150;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            CheckInventory();
            
        }
        if (timer) {
            clock++;
            if (clock > delay) {
                dialoguePanel.SetActive(false);
                clock = 0;
                timer = false;
                dialogueText.text = "";
                nameText.text = "";
            }

        }
    }

    public void AddItem(string itemName){
        inventory.Add(itemName);
        Debug.Log("adding: " + itemName);

    }

    public void RemoveItem(string itemName){
        inventory.Remove(itemName);

    }

    public void CheckInventory(){
        string inv = string.Join( ",", inventory.ToArray() );
        nameText.text = "Inventory:";
        dialogueText.text = inv;
        dialoguePanel.SetActive(true);
        timer = true;

    }
}
