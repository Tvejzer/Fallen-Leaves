using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerControl : MonoBehaviour
{
    private GameObject player;
    private DialogManager dialogManager;
    [SerializeField] private int TrigerID;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        dialogManager = FindObjectOfType<DialogManager>();
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            if (player.GetComponent<PlayerInteractor>().ChapterProgresss == TrigerID)
            {
                dialogManager.StartDialog(TrigerID);
            }
        }
    }
}
