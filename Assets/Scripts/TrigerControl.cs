using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerControl : MonoBehaviour
{
    private GameObject player;
    private DialogManager dialogManager;
    [SerializeField] private string TrigerID;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        dialogManager = FindObjectOfType<DialogManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            dialogManager.StartEvent(TrigerID);
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
