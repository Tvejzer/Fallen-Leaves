using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{


    private bool playerInRanghe;
    [SerializeField] private TextAsset inkJson;



    private void Awake()
    {
    }

    private void Update()
    {
        if (playerInRanghe)
        {
            GetComponent<SpriteRenderer>().enabled = false;
            print(inkJson.text);
        }
        else
        {
            GetComponent<SpriteRenderer>().enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRanghe = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRanghe = false;
        }
    }
}
