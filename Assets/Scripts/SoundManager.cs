using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private List<AudioClip> VoiceOverClip;
    [SerializeField] private AudioSource music;
    [SerializeField] private AudioSource pickUp;
    [SerializeField] private AudioSource doorSound;
    [SerializeField] private AudioSource hvala;
    [SerializeField] private AudioSource DialogVoiceOver;
    [SerializeField] private AudioSource death;
    [SerializeField] private AudioSource sfxTest7;
    [SerializeField] private AudioSource sfxTest8;
        

    public void SfxPickUp() 
    {
        pickUp.Play();
    }

    public void SfxDeath()
    {
        death.Play();
    }

    public void SfxDoor()
    {
        doorSound.Play();
    }
    public void SfxHvala()
    {
        hvala.Play();
    }

}
