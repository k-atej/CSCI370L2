using UnityEngine;

public class Car : MonoBehaviour
{

    public GameObject car;
    public int boundaryRight;
    public int boundaryLeft;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(car.transform.position.x <= boundaryLeft || car.transform.position.x >= boundaryRight){
            Destroy(car);
        }

    }

    

    /*
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name != "Player")
        {
            Destroy(col.gameObject);
        }
        
    }*/
    
}