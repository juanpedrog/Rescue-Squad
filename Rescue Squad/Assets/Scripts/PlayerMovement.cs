using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    public float speed;
    Rigidbody2D body;
    Animator anim;
	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        x = Input.GetAxis("Horizontal"); 
        if (x == 0 && y == 0)
        {
            moveStop();
        }
        if (x < 0)
        {
            moveLeft();
            x = 0;
        }
        if (x > 0)
        {
            moveRight();
            x = 0;
        }
        
        if (y < 0)
        {
            moveDown();
            x = 0;
        }
        if (y > 0)
        {
            moveUp();
            x = 0;
        }
	}
    void moveRight()
    {
        anim.SetBool("Run", true);
        anim.SetBool("Perfil", true);
        body.velocity = new Vector2(speed, 0);
        anim.SetBool("Down", false);
        anim.SetBool("Up", false);
        anim.SetBool("Left", false);
        anim.SetBool("RunLeft", false);
        anim.SetBool("RunBack", false);
        anim.SetBool("RunFront", false);
        
    }
    void moveLeft()
    {
        anim.SetBool("RunLeft", true);
        anim.SetBool("Left", true);
        body.velocity = new Vector2(-speed, 0);
        anim.SetBool("Down", false);
        anim.SetBool("Up", false);
        anim.SetBool("Perfil", false);
        anim.SetBool("Run", false);
        anim.SetBool("RunBack", false);
        anim.SetBool("RunFront", false);
        
    }
    void moveUp()
    {
        body.velocity = new Vector2(0,speed);
        anim.SetBool("Perfil", false);
        anim.SetBool("Down", false);
        anim.SetBool("Left", false);
        anim.SetBool("RunFront", false);
        anim.SetBool("Run", false);
        anim.SetBool("RunLeft", false);
        anim.SetBool("RunBack", true);
        anim.SetBool("Up", true);
    }
    void moveDown()
    {
        body.velocity = new Vector2( 0,-speed);
        anim.SetBool("Perfil", false);
        anim.SetBool("Up", false);
        anim.SetBool("Left", false);
        anim.SetBool("Run", false);
        anim.SetBool("RunLeft", false);
        anim.SetBool("RunBack", false);
        anim.SetBool("RunFront", true);
        anim.SetBool("Down", true);
    }
    void moveStop()
    {
        body.velocity = Vector2.zero;
        anim.SetBool("Run", false);
        anim.SetBool("RunLeft", false);
        anim.SetBool("RunBack", false);
        anim.SetBool("RunFront", false);
    }
}
