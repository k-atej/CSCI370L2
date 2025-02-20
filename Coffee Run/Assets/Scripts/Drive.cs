using System;
using UnityEngine;

public class Drive : MonoBehaviour
{

    private new Rigidbody2D rigidbody2D;
    public String direction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        if(direction =="Left"){
        rigidbody2D.AddForce(transform.right * -75);
        }
        else{
        rigidbody2D.AddForce(transform.right * 75);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}