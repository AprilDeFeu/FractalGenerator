using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    public float _sensitivity = 200f;
    public Transform viewer;

    float xRadial = 0f;
    // Start is called before the first frame update
    void Start()
    {
        // Hide cursor
        Cursor.lockState = CursorLockMode.Locked;
        transform.localRotation = Quaternion.Euler(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Get mouse input and make it constant over framerates.
        float x = Input.GetAxis("Mouse X") * _sensitivity * Time.deltaTime;
        float y = Input.GetAxis("Mouse Y") * _sensitivity * Time.deltaTime;

        // Set and lock rotation on y
        xRadial -= y;
        xRadial = Mathf.Clamp(xRadial, -90f, 90f);
        // Transform object with camera movement.
        transform.localRotation = Quaternion.Euler(xRadial, 0f, 0f);
        viewer.Rotate(Vector3.up * x);
        
    }
}
