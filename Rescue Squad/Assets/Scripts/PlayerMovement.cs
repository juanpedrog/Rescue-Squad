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
        if (x < 0)
        {
            moveLeft();
        }
        if (x > 0)
        {
            moveRight();
        }
        if (x == 0 && y==0)
        {
            moveStop();
        }
        if (y < 0)
        {
            moveDown();
        }
        if (y > 0)
        {
            moveUp();
        }
	}
    void moveRight()
    {
        body.velocity = new Vector2(speed, 0);
        anim.SetBool("Perfil", true);
        anim.SetBool("Down", false);
        anim.SetBool("Up", false);
        anim.SetBool("Left", false);
        anim.SetBool("Run",true);
    }
    void moveLeft()
    {
        body.velocity = new Vector2(-speed, 0);
        anim.SetBool("Left", true);
        anim.SetBool("Down", false);
        anim.SetBool("Up", false);
        anim.SetBool("Perfil", false);
    }
    void moveUp()
    {
        body.velocity = new Vector2(0,speed);
        anim.SetBool("Perfil", false);
        anim.SetBool("Down", false);
        anim.SetBool("Up", true);
        anim.SetBool("Left", false);
    }
    void moveDown()
    {
        body.velocity = new Vector2( 0,-speed);
        anim.SetBool("Perfil", false);
        anim.SetBool("Down", true);
        anim.SetBool("Up", false);
        anim.SetBool("Left", false);
    }
    void moveStop()
    {
        body.velocity = Vector2.zero;
        anim.SetBool("Run",false);
    }
}
