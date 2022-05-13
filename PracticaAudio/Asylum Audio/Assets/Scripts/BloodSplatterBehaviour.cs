using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodSplatterBehaviour : MonoBehaviour
{
    AudioSource audioSource;
    public GameObject bloodDrop;
    float audioClipTime = 2.0f;

    private void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (audioClipTime <= 0.0f)
        {
            audioSource.pitch = Random.Range(1.0f, 2.0f);
            audioSource.Play();
            audioClipTime = 2.0f;
            Instantiate(bloodDrop, this.transform);
        }
        else
        {
            audioClipTime -= Time.deltaTime;
        }
    }
}
