using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [Header("Config of arrow")]
    //speed of arrow
    [SerializeField] public float bullet_speed = 1.0f;

    //vector used to hold pos of mouse
    private Vector3 lookAtTargetPos;

    void Start()
    {
        //gets pos of mouse
        lookAtTargetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        lookAtTargetPos.z = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = lookAtTargetPos;

        //more info https://answers.unity.com/questions/56251/make-object-move-tofollow-another-object-plus-turn.html
        transform.position += lookAtTargetPos * Time.deltaTime * bullet_speed;

    }
}
