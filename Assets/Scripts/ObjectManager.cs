using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    private GameObject player;
    private bool playerCollision = false;
    private SoundManager soundManager;
    [SerializeField] bool destroy = false;


    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        soundManager = FindObjectOfType<SoundManager>();
    }


    public bool Destroyy
    {
        get
        {
            return destroy;
        }
        set
        {
            destroy = value;
        }
    }

    public SoundManager SoundManager
    {
        get
        {
            return soundManager;
        }
        set
        {
            soundManager = value;
        }
    }

    public GameObject Player
    {
        get
        {
            return player;
        }
        set
        {
            player = value;
        }
    }


    public bool PlayerCollision
    {
        get
        {
            return playerCollision;
        }
        set
        {
            playerCollision = value;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            PlayerCollision = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            PlayerCollision = false;
        }
    }
}
