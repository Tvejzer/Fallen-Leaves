using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{


    [SerializeField] private Sprite skinPassive;
    [SerializeField] private Sprite skinActive;
    private bool playerInRange;
    [SerializeField] private TextAsset inkJson;



    private void Awake()
    {
        playerInRange = false;
        GetComponent<SpriteRenderer>().enabled = false;
    }

    private void Update()
    {
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying)
        {
            Activate();
            if (InputManager.GetInstance().GetInteractPressed())
            {
                DialogueManager.GetInstance().EnterDialogueMode(inkJson);
            }
        }
        else
        {
            Deactivate();
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }

    public void Activate()
    {
        GetComponent<SpriteRenderer>().enabled = true;
        GetComponent<SpriteRenderer>().sprite = skinActive;
    }

    public void Deactivate()
    {
        GetComponent<SpriteRenderer>().enabled = true;
        GetComponent<SpriteRenderer>().sprite = skinPassive;
    }
}
