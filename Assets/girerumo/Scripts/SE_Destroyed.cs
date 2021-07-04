using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE_Destroyed : MonoBehaviour
{
    public AudioClip sound_destroyed;
    public AudioClip sound_collected;
    AudioSource audioSource;

    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }


    public void playSound_destroyed()
    {
        AudioSource.PlayClipAtPoint(sound_destroyed, transform.position);
    }

    public void playSound_collected()
    {
        AudioSource.PlayClipAtPoint(sound_collected, transform.position);
    }
}
