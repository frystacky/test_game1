using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public int bullet_speed = 1;
    public Vector3 lookAtTargetPos;

    // Start is called before the first frame update
    void Start()
    {
        lookAtTargetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        lookAtTargetPos.z = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = lookAtTargetPos;
    }
}
