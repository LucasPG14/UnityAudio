using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public AudioMixerSnapshot toCorridor;
    public AudioMixerSnapshot toSurgery;
    public AudioMixerSnapshot toForest;
    public AudioMixerSnapshot toStarterZone;
    public AudioMixerSnapshot toReception;

    // Start is called before the first frame update
    void Start()
    {
        toStarterZone.TransitionTo(0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToCorridor()
    {
        toCorridor.TransitionTo(1.0f);
    }

    public void GoToStarterZone()
    {
        toStarterZone.TransitionTo(1.0f);
    }

    public void GoToSurgery()
    {
        toSurgery.TransitionTo(1.0f);
    }

    public void GoToForest()
    {
        toForest.TransitionTo(1.0f);
    }

    public void GoToReception()
    {
        toReception.TransitionTo(1.0f);
    }

}
