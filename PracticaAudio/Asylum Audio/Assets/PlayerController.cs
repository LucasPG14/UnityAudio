using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float mouseSpeed = 5.0f;
    public SoundManager soundManager;
    public Camera cam;

    float xRotation = 0.0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.0f, 0.0f, Input.GetAxis("Vertical") * speed * Time.deltaTime);
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0.0f, 0.0f);

        float mouseX = Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90.0f, 90.0f);

        cam.transform.localRotation = Quaternion.Euler(xRotation, 0.0f, 0.0f);
        cam.transform.Rotate(Vector3.up * mouseX);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "ToStarterZone")
        {
            soundManager.GoToStarterZone();
        }
        else if (other.gameObject.name == "ToCorridor")
        {
            soundManager.GoToCorridor();
        }
        else if (other.gameObject.name == "ToSurgery")
        {
            soundManager.GoToSurgery();
        }
        else if (other.gameObject.name == "ToForest")
        {
            soundManager.GoToForest();
        }
        else if (other.gameObject.name == "ToHospital")
        {
            soundManager.GoToReception();
        }
        else if (other.gameObject.name == "Shower")
        {
            other.gameObject.GetComponent<AudioSource>().Play();
        }
     
    }
}
