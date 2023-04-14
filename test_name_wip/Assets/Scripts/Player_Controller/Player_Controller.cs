using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
   
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Rigidbody2D rb2d = null;

    Vector2 movement;

    void Start()
    {
        
    }

   
    void Update()
    {
        //new movement code to make movement smoother and save performance, for old code checkout github
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }


    //this makes it frame independent and updates according to time, 50 times per second
    void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

}
