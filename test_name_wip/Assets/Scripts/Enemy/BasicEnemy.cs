using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    [Header("Enemy Stat Config")]
    [SerializeField] private int hp = 100;
    [SerializeField] private float movespeed = 5;
    [SerializeField] public EnemyStats stats;
    [SerializeField] private int force = -1000;
    [SerializeField] public int damageAmountToPlayer = 10;

    private GameObject Player;
    

    void Start()
    {
        //initialize enemy hp and movespeed
        stats = GetComponent<EnemyStats>();
        stats.sethp(this.hp);
        stats.setMoveSpeed(this.movespeed);
        stats.setDamageAmountToPlayer(this.damageAmountToPlayer);

        Player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //kill enemy if HP goes under 0
        if (stats.gethp() <= 0)
        {
            Destroy(this.gameObject);   
        }
        
        //move the enemy to follow the player's position
        float step = movespeed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, step);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject incomingObject = collision.gameObject;

        if (incomingObject.CompareTag("Player"))
        {
            //TODO fix the negative math here, should be a positve number
            //this knocks back the player on damage taken
            Vector2 Direction = (transform.position - incomingObject.transform.position).normalized;
            incomingObject.GetComponent<Rigidbody2D>().AddForce(Direction * force);

            //player takes damage logic
            incomingObject.GetComponent<Player_Stats>().takeDamage(stats.getDamageAmountToPlayer());
        }
    }

} 