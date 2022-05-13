using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float mouseSpeed = 5.0f;
    public SoundManager soundManager;

    float xRotation = 0.0f;

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
