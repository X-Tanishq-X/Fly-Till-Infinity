using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket_Script : MonoBehaviour
{
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        inputprocess();
    }
    private void inputprocess()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddRelativeForce(Vector3.up);
        }
        
    }
}
