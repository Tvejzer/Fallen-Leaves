using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractor : MonoBehaviour
{

    [SerializeField] private bool have_key = false;
    [SerializeField] private bool have_cure = false;
    [SerializeField] private bool movement = true;
    [SerializeField] private int chapterProgress = 0;


    public int ChapterProgresss
    {
        get
        {
            return chapterProgress;
        }
        set
        {
            chapterProgress = value;
        }
    }

    public bool PlayerMovement
    {
        get
        {
            return movement;
        }
        set
        {
            movement = value;
        }
    }

    public bool KeyValue
    {
        get
        {
            return have_key;
        }
        set
        {
            have_key = value;
        }
    }

    public bool CureValue
    {
        get
        {
            return have_cure;
        }
        set
        {
            have_cure = value;
        }
    }
}
