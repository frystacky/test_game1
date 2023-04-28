using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillsController : MonoBehaviour
{
    public GameObject archerSkill;


    public void FireSkills(string classType)
    {
        if(classType == "archer")
        {
            archerSkill.SetActive(true);
        }

    }
        
}
