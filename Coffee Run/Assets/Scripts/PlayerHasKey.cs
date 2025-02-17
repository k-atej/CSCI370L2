using UnityEngine;

public class ShopOwnerLeaves : MonoBehaviour
{

    public DialogueAsset ownerDialogue;
    public DialogueAsset shopDialogue;
   // public GameObject player;

    //public GameObject shopOwnerBody;

   // public GameObject shopBody;
    public Inventory inventory;

    public NPC shopOwner;
    public NPC shop;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inventory.HasKey()){
            shopOwner.ChangeDialogue(ownerDialogue);
            shop.ChangeDialogue(shopDialogue);
        }
        
    }
}
