using UnityEngine;

public class PlayerHasKeys : MonoBehaviour
{

    public DialogueAsset ownerDialogue;
    public DialogueAsset shopDialogue;

    public GameObject ownerBody;
    public GameObject ownerLight;

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
            shopOwner.repeatStartPosition = 0;
            Debug.Log("Dialogue Updated");
        }
        if(ownerInv.HasItem("Keys")){
            Destroy(ownerBody);
            Destroy(ownerLight);
            shop.ChangeDialogue(shopDialogue);
            shop.repeatStartPosition = 0;
            GameManager.Instance.shopIsOpen = true;
            Debug.Log("Owner Unlocked door");

        }        
    }
}
