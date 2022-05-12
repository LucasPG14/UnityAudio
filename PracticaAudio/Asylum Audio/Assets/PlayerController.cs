using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float mouseSpeed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.0f, 0.0f, Input.GetAxis("Vertical") * speed * Time.deltaTime);
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0.0f, 0.0f);

        transform.Rotate(-Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime, Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime, 0.0f);
    }
}
