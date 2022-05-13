using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnnouncerScript : MonoBehaviour
{
    public bool start = false;
    float limit = 4.0f;
    public AudioClip[] clips;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            limit -= Time.deltaTime;

            if (limit >= 0.0f)
            {
                audioSource.pitch -= 0.15f * Time.deltaTime;
            }
            else
            {
                audioSource.Stop();
                audioSource.pitch = 1.0f;
                limit = 4.0f;
                start = false;
                audioSource.PlayOneShot(clips[1]);
            }
        }
    }

    public void StartAudio()
    {
        start = true;
        audioSource.PlayOneShot(clips[0]);
    }
}
