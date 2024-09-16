using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer render;
    Rigidbody rigidbdy;
    [SerializeField] float timeToWait = 4f;
    // Start is called before the first frame update
    void Start()
    {   
        render = GetComponent<MeshRenderer>();
        rigidbdy = GetComponent<Rigidbody>();
        
        render.enabled = false;
        rigidbdy.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait)
        {
            render.enabled = true;
            rigidbdy.useGravity = true;
        }
    }
}
