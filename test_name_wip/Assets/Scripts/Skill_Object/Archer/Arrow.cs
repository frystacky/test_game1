using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Burst.CompilerServices;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [Header("Config of arrow")]
    //speed of arrow
    [SerializeField] public float missle_speed = 1f;
    [SerializeField] public int missileDamage = 50;
    [SerializeField] public int missilePen = 2;

    private Camera mainCam;
    private Rigidbody2D rb;

    //vector used to hold pos of mouse
    private Vector3 mousePos;

    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rb = GetComponent<Rigidbody2D>();

        //gets pos of mouse
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePos - transform.position;

        rb.velocity = new Vector2(direction.x, direction.y).normalized * missle_speed;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject incomingObject = collision.gameObject;

        if (incomingObject.CompareTag("Enemy"))
        {
            incomingObject.GetComponent<EnemyStats>().takeDamage(missileDamage);
            missilePen -= 1;

            if (missilePen <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
