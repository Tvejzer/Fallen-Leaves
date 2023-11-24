using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerControl : MonoBehaviour
{
    [SerializeField] private Sprite skinPassive;
    [SerializeField] private Sprite skinActive;
    private GameObject player;
    private DialogManager dialogManager;
    [SerializeField] private int TrigerID;
    [SerializeField] private int Appear;
    private int chapterProgress;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        dialogManager = FindObjectOfType<DialogManager>();
        chapterProgress = player.GetComponent<PlayerInteractor>().ChapterProgresss;


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            if (chapterProgress == Appear)
            {
                dialogManager.OnTrigger(TrigerID);
            }
        }
    }


    private void Update()
    {
        chapterProgress = player.GetComponent<PlayerInteractor>().ChapterProgresss;

        if (chapterProgress != TrigerID & chapterProgress != Appear)
        {
            GetComponent<SpriteRenderer>().enabled = false;
        }
        if (chapterProgress == TrigerID | chapterProgress == Appear)
        {
            GetComponent<SpriteRenderer>().enabled = true;
        }
    }
    public void Activate()
    {
        GetComponent<SpriteRenderer>().sprite = skinActive;
    }

    public void Deactivate()
    {
        GetComponent<SpriteRenderer>().sprite = skinPassive;
    }

}
