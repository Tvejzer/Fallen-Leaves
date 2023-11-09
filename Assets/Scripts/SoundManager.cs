using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource music;
    [SerializeField] private AudioSource pickUp;
    [SerializeField] private AudioSource doorSound;
    [SerializeField] private AudioSource hvala;
    [SerializeField] private AudioSource sfxTest5;
    [SerializeField] private AudioSource sfxTest6;
    [SerializeField] private AudioSource sfxTest7;
    [SerializeField] private AudioSource sfxTest8;
        

    public void SfxPickUp() 
    {
        pickUp.Play();
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
