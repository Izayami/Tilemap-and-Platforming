﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioObject2 : MonoBehaviour
{
    public AudioClip MusicClip;
    public AudioSource MusicSource; 

    private int count;
    // Start is called before the first frame update
    void Start()
    {
        MusicSource.clip = MusicClip;
    }

    // Update is called once per frame
    void Update()
    {
        if(count == 4)
        MusicSource.Play();
    }
}
