using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_DestroyOverTime : MonoBehaviour
{
    public float timmer = 3f;


    void Start()
    {
        Destroy(gameObject, timmer);
    }

}
