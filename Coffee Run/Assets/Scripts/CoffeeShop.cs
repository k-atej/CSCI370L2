using UnityEngine;

public class CoffeeShop : MonoBehaviour
{

    public bool open;

    public Inventory inv;


    public Sprite updated;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inv.HasItem("Coffee")){
            GetComponent<SpriteRenderer>().sprite = updated;
        }
        else{
        Debug.Log("Looking for NPC");
            RaycastHit2D hit = Physics2D.CircleCast(transform.position, 2, Vector2.up, 0, LayerMask.GetMask("NPC"));
            if (hit)
            {
                Debug.Log("Hit Something!!" + hit.collider.gameObject.name);

                if (hit.collider.gameObject.TryGetComponent(out NPC npc))
                {
                    if(npc.name == "Shop"){
                        if(open){
                        addCoffee();
                        }
                    }
                }
            }
        }
        
    }

    void addCoffee(){
        inv.AddItem("Coffee");
        Debug.Log("Added Coffee");
    }
}
