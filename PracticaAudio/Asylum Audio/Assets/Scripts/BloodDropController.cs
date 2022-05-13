using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class BloodDropController : MonoBehaviour
{
    AudioSource audioSource;
    float destroyTime = 5.0f;
    bool readyToDestroy = false;
    bool playOnce = false;
    private void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (readyToDestroy)
        {
            if (!playOnce)
            {
                gameObject.GetComponent<MeshRenderer>().enabled = false;
                PlaySplashSound();
                playOnce = true;
            }

            if (destroyTime <= 0.0f)
            {
                Destroy(this.gameObject);
            }
            destroyTime -= Time.deltaTime;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        readyToDestroy = true;   
    }

    public void PlaySplashSound()
    {
        audioSource.pitch = Random.Range(1.0f, 2.0f);
        audioSource.Play();
        Debug.Log("playing");
    }
}
