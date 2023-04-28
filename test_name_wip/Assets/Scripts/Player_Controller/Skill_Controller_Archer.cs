using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer_SkillController : MonoBehaviour
{
    [Header("Basic attack Config")]
    public int arrowSpawnSpeed = 3;
    public GameObject arrow;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BasicAttack();
    }

    private void BasicAttack()
    {
        if (Time.time > arrowSpawnSpeed)
        {
            arrowSpawnSpeed += 2;
            Instantiate(arrow, gameObject.transform.position, Quaternion.identity);
        }

    }
}
