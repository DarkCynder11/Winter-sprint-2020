using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovment : MonoBehaviour
{
    public float speed;
    private Vector2 moveVelocity;

    public GameObject Player;

    public Vector3 scaleChangeLeft;
    public Vector3 scaleChangeRight;

    private Rigidbody2D cRB;

    void Start()
    {
        cRB = GetComponent<Rigidbody2D>();
        scaleChangeLeft = new Vector3(-1f, 1f, 1f);
        scaleChangeRight = new Vector3(1f, 1f, 1f);
    }

    void Update()
    {
        Vector2 moveInput = new Vector2(0, Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput * speed;

        Vector2 changeDirection = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            Player.transform.localScale = scaleChangeLeft;
        }
        else if(Input.GetAxisRaw("Horizontal") > 0)
        {
            Player.transform.localScale = scaleChangeRight;
        }
    
    }

    void FixedUpdate()
    {
        cRB.MovePosition(cRB.position + moveVelocity * Time.fixedDeltaTime);
    }

}
