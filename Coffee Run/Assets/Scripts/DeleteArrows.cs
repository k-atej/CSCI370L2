using UnityEngine;

public class DeleteArrows : MonoBehaviour
{
    public GameObject arrow1;
    public GameObject arrow2;
    public GameObject arrow3;
    public GameObject arrow4;
    public GameObject arrow5;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(arrow1);
        Destroy(arrow2); 
        Destroy(arrow3); 
        Destroy(arrow4); 
        Destroy(arrow5);   
    }
}
