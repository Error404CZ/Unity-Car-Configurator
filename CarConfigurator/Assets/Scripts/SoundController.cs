using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField] private AudioSource audioSourceMusic;
    [SerializeField] private AudioSource audioSourceMotor;

    [SerializeField] private AudioClip audioClipMotor;
    [SerializeField] private List<AudioClip> audioMusic = new List<AudioClip>();
    // Start is called before the first frame update
    void Start()
    {
        audioSourceMusic.clip = audioClipMotor;
        //audioSourceMotor.clip = audioMusic[0];
    }
    
    public void PlayMotorSound()
    {
        audioSourceMotor.Play();
    }
}
