using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public int counter = 6;
    public TMP_Text counterDisplay;
    public Inventory inventory;

    public NPC milly;
    public NPC oldman;
    public NPC neighbor;
    public NPC workerA;
    public NPC workerB;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        counterDisplay.SetText("6");
    }

    // Update is called once per frame
    void Update()
    {
        counterDisplay.SetText(getText());
    }

    private string getText(){
        counter = 6;
        counter -= checkNPC(milly);
        counter -= checkNPC(oldman);
        counter -= checkNPC(neighbor);
        counter -= checkNPC(workerA);
        counter -= checkNPC(workerB);
        counter -= checkPlayer();

        return counter.ToString();

    }

    private int checkNPC(NPC npc){
        bool cur = npc.checkCaffeinated(); // true if caffeinated
        if (cur) {
            return 1;
        }
        else{
            return 0;
        }
        
    }

    private int checkPlayer(){
        if (inventory.HasItem("Coffee")){
            return 1;
        } else{
            return 0;
        }

    }


}