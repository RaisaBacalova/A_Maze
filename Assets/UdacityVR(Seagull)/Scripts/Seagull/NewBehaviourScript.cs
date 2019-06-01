using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public GameObject objectToCreate;
	// Use this for initialization
	void Start () {
        for (int i = 0; i < 100; i++)
        {
            // Object.Instantiate(objectToCreate, new Vector3(i, i, i), Quaternion.identity);
            GameObject newSeagull = (GameObject)Object.Instantiate(objectToCreate, new Vector3(6.72731f, i, 451.5814f), Quaternion.identity);
            Renderer objectRenderer = newSeagull.GetComponentInChildren<Renderer>();
            objectRenderer.material.color = Color.black;        }

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
