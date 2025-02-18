using UnityEngine;

public class GivingCoffee : MonoBehaviour
{

    public DialogueAsset npcDialogue;

    public GameObject npcBody;

    public Inventory inventory;

    public NPC npc;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inventory.HasItem("Coffee")){
            npc.ChangeDialogue(npcDialogue);
            npc.repeatStartPosition = 5;
            Debug.Log("Caffinated");
        }   
    }
}
