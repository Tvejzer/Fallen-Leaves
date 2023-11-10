using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerControl : MonoBehaviour
{
    private GameObject player;
    private DialogManager dialogManager;
    [SerializeField] private int TrigerID;
     private int ChapterNumber;
     private string ChapterName;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        dialogManager = FindObjectOfType<DialogManager>();
        
    }
    private void Start()
    {
        ChapterName = dialogManager.ChapterList[TrigerID];
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            dialogManager.StartDialog(ChapterName);
        }
    }
}
