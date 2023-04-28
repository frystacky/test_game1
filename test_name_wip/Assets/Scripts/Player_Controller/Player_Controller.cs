using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [Header("Player Stat Config")]
    [SerializeField] private string charType = "archer"; 
    [SerializeField] private float moveSpeed = 5f;


    [Header("Skills controller")]
    public SkillsController skillController;



    [SerializeField] private Rigidbody2D rb2d = null;

    Vector2 movement;

    void Start()
    {
        //starts skill according to class
        skillController.FireSkills(charType);
    }

   
    void Update()
    {

        //player movment
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //player pause controller/menu controller

        //weapon controller to edit skills
        

    }


    //this makes it frame independent and updates according to time, 50 times per second
    void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + movement * moveSpeed * Time.fixedDeltaTime);

    }

}
