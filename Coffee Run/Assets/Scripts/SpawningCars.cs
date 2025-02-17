using UnityEngine;

public class SpawningCars : MonoBehaviour
{

    public GameObject car;
    
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnCar", 5.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    void SpawnCar()
    {
        var position = new Vector2(transform.position.x, transform.position.y); // source 1
        Instantiate(car, position, Quaternion.identity);
        
       


    }
}