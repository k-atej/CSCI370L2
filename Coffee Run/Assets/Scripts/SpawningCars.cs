using UnityEngine;

public class SpawningCars : MonoBehaviour
{

    public GameObject car;
    
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnCar", Random.Range(0f, 2.5f), Random.Range(2.5f, 5.5f));
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