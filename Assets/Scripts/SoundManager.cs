using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private List<AudioClip> VoiceOverClip;
    private List<AudioClip> sFX;
    [SerializeField] private AudioSource SFX_Player;
    [SerializeField] private AudioSource DialogVoiceOver;
    private void Awake()
    {
        VoiceOverClip = new List<AudioClip>(Resources.LoadAll<AudioClip>("VoiceOverClips"));
        sFX = new List<AudioClip>(Resources.LoadAll<AudioClip>("SFX"));
    }

    public void DialogVoice(int id)
    {
        if (VoiceOverClip[id] != null)
        {
            DialogVoiceOver.clip = VoiceOverClip[id];
            DialogVoiceOver.Play();
        }
    }

    public void DialogStop()
    {
        DialogVoiceOver.Stop();
    }
    public void SfxPickUp() 
    {
        SFX_Player.clip = sFX[1];
        SFX_Player.Play();
    }

    public void SfxDoor()
    {
        SFX_Player.clip = sFX[2];
        SFX_Player.Play();
    }
    public void SfxDeath()
    {
        SFX_Player.clip = sFX[3];
        SFX_Player.Play();
    }

    public void SfxHvala()
    {
        SFX_Player.clip = sFX[4];
        SFX_Player.Play();
    }

}
