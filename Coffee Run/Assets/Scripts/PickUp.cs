using UnityEngine;

public class PickUp : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public GameObject obj;
    public Inventory inventory;
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
        inventory.AddItem(obj.name);
        Destroy(obj);
    }

}
