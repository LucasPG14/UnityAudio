using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    enum FloorType
    {
        CONCRETE = 0,
        FOREST,
        WOOD
    }
    public float speed = 5.0f;
    public float mouseSpeed = 5.0f;
    public SoundManager soundManager;
    public AudioClip[] clips;
    public AudioReverbZone reverbHospital;
    public AudioReverbZone reverbHouse;

    AudioSource audioSource;
    FloorType type;

    private void Start()
    {
        type = FloorType.CONCRETE;
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "ToStarterZone")
        {
            reverbHospital.enabled = true;
            reverbHouse.enabled = false;
            soundManager.GoToStarterZone();
        }
        else if (other.gameObject.name == "ToCorridor")
        {
            reverbHospital.enabled = true;
            reverbHouse.enabled = false;
            soundManager.GoToCorridor();
        }
        else if (other.gameObject.name == "ToSurgery")
        {
            reverbHospital.enabled = true;
            reverbHouse.enabled = false;
            soundManager.GoToSurgery();
        }
        else if (other.gameObject.name == "ToForest")
        {
            reverbHospital.enabled = false;
            reverbHouse.enabled = false;
            soundManager.GoToForest();
        }
        else if (other.gameObject.name == "ToHospital")
        {
            reverbHospital.enabled = true;
            reverbHouse.enabled = false;
            soundManager.GoToReception();
        }
        else if (other.gameObject.name == "Shower")
        {
            reverbHospital.enabled = true;
            reverbHouse.enabled = false;
            other.gameObject.GetComponent<AudioSource>().Play();
        }
        else if (other.gameObject.name == "VoiceAnnouncer")
        {
            other.gameObject.GetComponent<AnnouncerScript>().StartAudio();
        }
        else if (other.gameObject.name == "House")
        {
            reverbHospital.enabled = false;
            reverbHouse.enabled = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "House")
        {
            reverbHospital.enabled = false;
            reverbHouse.enabled = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Concrete")
        {
            type = FloorType.CONCRETE;
        }
        else if (collision.gameObject.tag == "Forest")
        { 
            type = FloorType.FOREST;
        }
        else if (collision.gameObject.tag == "Wood")
        {
          type = FloorType.WOOD;
        }
    }
    public void PlayFootStep()
    {
        audioSource.pitch = Random.Range(1.0f, 3.0f);

        if (type == FloorType.CONCRETE)
        {
            audioSource.PlayOneShot(clips[0]);
        }
        else if (type == FloorType.FOREST)
        {
            audioSource.PlayOneShot(clips[1]);
        }
        else if (type == FloorType.WOOD)
        {
            audioSource.PlayOneShot(clips[2]);
        }
    }
}
