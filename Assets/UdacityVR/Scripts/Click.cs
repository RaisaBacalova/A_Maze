using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {

    public GameObject GameObject;

    private void OnTriggerEnter(Collider other)
    {


        transform.Translate(0, 3.5f * Time.deltaTime, 0, Space.World);

    }
}
