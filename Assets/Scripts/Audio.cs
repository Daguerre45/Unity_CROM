
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip[] clips;
    private AudioSource audioS;
    
    // Start is called before the first frame update
    void Start()
    {
        audioS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void PlayAudio(int index)
    {
        audioS.clip = clips[index];
        audioS.Play();

    }
}
