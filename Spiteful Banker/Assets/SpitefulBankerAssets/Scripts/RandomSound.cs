using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSound : MonoBehaviour
{
    public AudioSource _audiosource;
    public AudioClip[] audioClip;

    private void Awake()
    {
        _audiosource = GetComponent<AudioSource>();
    }

    void Start()
    {
        _audiosource.clip = audioClip[Random.Range(0, audioClip.Length)];
        _audiosource.PlayOneShot(_audiosource.clip);
    }

}
