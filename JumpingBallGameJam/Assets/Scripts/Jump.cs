using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    public Rigidbody2D rb2dBall;
    private bool canJump = false;

    // Use this for initialization
    void Start () {
        rb2dBall = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            if(canJump)
                rb2dBall.AddForce(Vector2.up * 10f, ForceMode2D.Impulse);

        }

    }

    void OnCollisionExit2D(Collision2D collisionInfo)
    {
        canJump = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        canJump = true;
    }
}
