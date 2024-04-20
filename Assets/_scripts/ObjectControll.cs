using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectControll : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        float speed = 0.01f;
        Vector3 vector = new Vector3(15,30,45);
        transform.Rotate(vector*speed);
    }

    
}
