using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodSplatterBehaviour : MonoBehaviour
{
    public GameObject bloodDrop;
    float audioClipTime = 2.0f;

    // Update is called once per frame
    void Update()
    {
        if (audioClipTime <= 0.0f)
        {
            audioClipTime = 2.0f;
            Instantiate(bloodDrop, this.transform);
        }
        else
        {
            audioClipTime -= Time.deltaTime;
        }
    }
}
