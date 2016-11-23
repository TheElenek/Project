using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float movespeed;
    public float jump;
    public float duck;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update ()
    {
        if(Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-movespeed, 0);
        }
         
        if(Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(movespeed, 0);
        }

        if(Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, jump);
            
        }
        anim.SetFloat("height", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.y));

        if (Input.GetKey(KeyCode.S))
        {
            
        }
        
    }
}
