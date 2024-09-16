using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAngle = 0;
    float yAngle = 0.44F;
    [SerializeField] float zAngle = 0;
   
    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    
    }
}
