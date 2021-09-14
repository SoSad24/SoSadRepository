using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPositions;

    private float movement;

    void Start()
    {
        startPositions = transform.position;
    }
    private void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxis("Vertical");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPositions;
    }

}
