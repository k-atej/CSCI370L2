using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if(GameManager.Instance.allAreCaffienated == true){
            Instructions.text = "Good Job!! You saved your town! Thanks for playing";
        }
        else if(GameManager.Instance.started == true){
            Instructions.text = "There's still people who need your help!";
        }
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
