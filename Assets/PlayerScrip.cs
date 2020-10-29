using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScrip : MonoBehaviour
{
    [SerializeField]
    Vector3 ve3force;

    [SerializeField]
    KeyCode keyright;

    [SerializeField]
    KeyCode keyleft;

    void Update()
    {
        if (Input.GetKey(keyright))
        GetComponent<Rigidbody>().velocity += ve3force;

        if(Input.GetKey(keyleft))
        GetComponent<Rigidbody>().velocity -= ve3force;
    }
}
