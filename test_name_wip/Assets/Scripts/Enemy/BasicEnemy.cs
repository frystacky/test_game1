using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    [Header("Enemy Stat Config")]
    [SerializeField] private int hp = 100;
    [SerializeField] private float movespeed = 0;
    [SerializeField] public EnemyStats stats;

    void Start()
    {
        //initialize enemy hp and movespeed
        stats = GetComponent<EnemyStats>();
        stats.sethp(this.hp);
        stats.setMoveSpeed(this.movespeed);
    }

    // Update is called once per frame
    void Update()
    {
        //kill enemy if HP goes under 0
        if (stats.gethp() <= 0)
        {
            Destroy(this.gameObject);   
        }
    }
} 