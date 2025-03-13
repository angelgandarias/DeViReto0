using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityPhysics : MonoBehaviour
{
    //Básicamente simulo la física gravitatoria del sistema solar (ignorando las masas) para conseguir las elipses
    public GameObject parentObject;
    public GameObject childObject;
    private const float gravity = -1;
    public Vector3 speed;
    private Vector3 distance;

    // Start is called before the first frame update
    void Start()
    {
        
        distance = (childObject.transform.position - parentObject.transform.position);

    }

    // Update is called once per frame
    void Update()
    {
        childObject.transform.position = childObject.transform.position + speed;
        distance = (childObject.transform.position - parentObject.transform.position);
        speed += (float)(gravity * (1/Math.Pow((distance.magnitude),2))) * distance.normalized;

    }
}
