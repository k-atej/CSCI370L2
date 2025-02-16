using UnityEngine;

public class Car : MonoBehaviour
{

    public GameObject car;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(car.transform.position.x <= -11 || car.transform.position.x >= 10){
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