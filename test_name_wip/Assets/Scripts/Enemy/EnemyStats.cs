using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    private int hp = 0;
    private float movespeed = 0f;

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