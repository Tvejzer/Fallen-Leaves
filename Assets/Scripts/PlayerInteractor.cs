using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractor : MonoBehaviour
{
    private MoverManager moverManager;
    [SerializeField] private bool have_key = false;
    [SerializeField] private bool have_cure = false;
    [SerializeField] private bool movement = true;
    [SerializeField] private int chapterProgress = 0;
    [SerializeField] private bool MoveDoc1 = false;
    [SerializeField] private bool forseSpawn = false;

    private void Awake()
    {
        moverManager = FindObjectOfType<MoverManager>();
    }
    private void Update()
    {

        if (forseSpawn)
        {
            transform.position = new Vector3(80,21,-2);
            have_key = false;
            have_cure = false;
            movement = true;
            chapterProgress = 0;
            MoveDoc1 = false;
            forseSpawn = false;
        }

        if (MoveDoc1)
        {
            moverManager.Event1();
            MoveDoc1 = false;
        }
    }


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

    public bool ForseSpawn
    {
        get
        {
            return forseSpawn;
        }
        set
        {
            forseSpawn = value;
        }
    }

    public bool GameEnded { get; set; }
}
