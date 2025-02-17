using UnityEngine;

public class PlayerHasKeys : MonoBehaviour
{

    public DialogueAsset ownerDialogue;
    public DialogueAsset shopDialogue;

    public GameObject ownerBody;

    public Inventory inventory;

    public NPC shopOwner;
    public NPC shop;

    public Inventory ownerInv;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inventory.HasItem("Keys")){
            shopOwner.ChangeDialogue(ownerDialogue);
            shopOwner.repeatStartPosition = 1;
            Debug.Log("Dialogue Updated");
        }
        if(ownerInv.HasItem("Keys")){
            Destroy(ownerBody);
            shop.ChangeDialogue(shopDialogue);
            shop.repeatStartPosition = 0;
            Debug.Log("Owner Unlocked door");
        }
        
    }
}
