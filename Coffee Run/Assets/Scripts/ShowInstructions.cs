using TMPro;
using UnityEngine;

public class ShowInstructions : MonoBehaviour

{
    public TextMeshProUGUI Instructions;

    private Rigidbody2D rb2d;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
        rb2d = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
    }
     void OnTriggerEnter2D(Collider2D col)
    {
        Instructions.canvasRenderer.SetAlpha(100);

    }

    void OnTriggerExit2D(Collider2D col)
    {
        Instructions.canvasRenderer.SetAlpha(0);

    }
}
