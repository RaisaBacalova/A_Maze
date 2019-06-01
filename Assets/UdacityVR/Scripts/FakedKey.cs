using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakedKey : MonoBehaviour {

    // Use this for initialization

    public GameObject keyPoofPrefab;
    public Door door;
    public GameObject fakedKey;
    // Update is called once per frame

    void Update () {
        fakedKey.transform.Rotate(Time.deltaTime * 6, 0, 0);
        fakedKey.transform.Rotate(0, Time.deltaTime * 30, 0, Space.World);
    }

    public void OnFakedKeyClick()
    {
        Debug.Log("'Key.OnFakedKeyClick()' was called");
        door.Fail();
        Object.Instantiate(keyPoofPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject, 1);
    }
}
