using UnityEngine;

public class PickUp : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public GameObject obj;
    public int endingLayer;
    public Inventory inventory;

   // public ParticleSystem t;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Interact();
        }
    }

    void Interact() {
        if(obj.name == "Coffee"){
        if(GameManager.Instance.shopIsOpen){
            inventory.AddItem(obj.name);
            Renderer myRenderer = GetComponent<Renderer>();
            myRenderer.sortingOrder = endingLayer;
            //t.Play();
        }
        }
        else{
        inventory.AddItem(obj.name);
        Renderer myRenderer = GetComponent<Renderer>();
        myRenderer.sortingOrder = endingLayer;
        }
    }

}
