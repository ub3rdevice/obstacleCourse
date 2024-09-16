using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{   
    float moveSpeed = 4;

    // Start is called before the first frame update
    void Start()
    {
        ShowTutorial();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }

    void movePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue,0,zValue);
    }
    void ShowTutorial()
    {
        Debug.Log("Welcome!");
        Debug.Log("Use WASD or Arrow keys for movement.");
        Debug.Log("Try not to collide with obstacles!");
        Debug.Log("Good luck and have fun!");
    }

}
