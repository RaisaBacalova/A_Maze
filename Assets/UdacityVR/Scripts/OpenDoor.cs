using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject cube;
    public GameObject canvas;
    public BoxCollider cubeCollider;
  
    float timer = 1f;
   


    public void EnterTheGame()
    {
        Debug.Log("My method was called");

        transform.Translate(0, 15f * timer, 0, Space.World);
       canvas.transform.Translate(0, 15f * timer, 0, Space.World);

      
        Destroy(canvas, 1);
        Destroy(cubeCollider, 1);

    }

}

