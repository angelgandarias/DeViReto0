using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystemScript : MonoBehaviour
{
    public GameObject parentObject;
    public GameObject childObject;
    public int rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        childObject.transform.SetParent(parentObject.transform);
      
        
    }

    // Update is called once per frame
    void Update()
    {
        childObject.transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime);
        childObject.transform.Rotate(0, 0.1f, 0, Space.Self);
        //moon.transform.Rotate(0, 0.1f, 0, Space.World);

    }
}
