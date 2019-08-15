using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
    public AudioClip soundPlay;
    AudioSource myAudio;

    
    // Use this for initialization
    void Start () {
        myAudio = this.gameObject.GetComponent<AudioSource>();
        myAudio.clip = soundPlay;
        myAudio.Play();

    }

    // Update is called once per frame
    void Update () {
		
	}
}
