using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Camera cam;
    public CharacterController ctl;
    public float _speed = 25f;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            _speed++;
        } 
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (_speed > 0) _speed--;
        }

            Vector3 movement = transform.right * x + transform.forward * z + cam.transform.forward * z;

        ctl.Move(movement * _speed * Time.deltaTime);
    }
}
