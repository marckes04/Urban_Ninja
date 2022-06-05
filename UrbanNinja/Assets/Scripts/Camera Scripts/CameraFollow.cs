using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform myTransform;
    private Transform target;
    public Vector3 Offset = new Vector3(3f,7.5f,-8f);

    void Awake()
    {
        target = GameObject.Find("Ninja").transform;
    }

    void Start()
    {
        myTransform = this.transform;
    }

    void Update()
    {
        if (target)
        {
            myTransform.position = target.position + Offset;
            myTransform.LookAt(transform.position, Vector3.up);
        }
    }
}
