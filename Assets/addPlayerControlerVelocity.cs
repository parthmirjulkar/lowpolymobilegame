using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayercontrolVelocity: MonoBehaviour
{
    [SerializeField]
    Vector3 ve3force;

    [SerializeField]
    KeyCode right;

    [SerializeField]
    KeyCode keyleft; 


    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity += ve3force;
    }
}
