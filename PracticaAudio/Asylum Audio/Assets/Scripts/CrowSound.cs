using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowSound : MonoBehaviour
{
    float countdown;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        countdown = Random.Range(1.0f, 3.0f);
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            countdown -= Time.deltaTime;
        }
        
        if (countdown <= 0.0f)
        {
            audioSource.pitch = Random.Range(1.0f, 1.3f);
            audioSource.Play();
            countdown = Random.Range(1.0f, 3.0f);
        }
    }
}
