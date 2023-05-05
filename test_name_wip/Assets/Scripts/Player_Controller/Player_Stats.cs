using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Stats : MonoBehaviour
{
    [Header("Player Stats to be set by Player_Controller")]
    [SerializeField] private int hp = 0;
    [SerializeField] private float movespeed = 0f;

    public int gethp()
    {
        return this.hp;
    }

    public void sethp(int hp)
    {
        this.hp = hp;
    }

    public float getMoveSpeed()
    {
        return this.movespeed;
    }

    public void setMoveSpeed(float movespeed)
    {
        this.movespeed = movespeed;
    }

    public void takeDamage(int damage)
    {
        this.hp -= damage;
    }
}