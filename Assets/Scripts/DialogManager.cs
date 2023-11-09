using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    private GameObject player;
    [SerializeField] private GameObject dialogDoc1;
    [SerializeField] private GameObject dialogDoc2;
    //[SerializeField] private GameObject dialogZorka;
    //[SerializeField] private GameObject dialogHom;
    //[SerializeField] private Sprite[] dialoglist;
    [SerializeField] private List<Sprite> dialogSprites;
    [SerializeField] private GameObject[] trigers;
    [SerializeField] private Dictionary<int, GameObject> dialogarray;


    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    public void StartEvent(string TrigerID)
    {
        player.GetComponent<PlayerInteractor>().PlayerMovement = false;

        switch (TrigerID)
        {
            case "FirstDialog":
                StartCoroutine(FirstDialog());
                break;
        }
    }

    private void ExitEvent()
    {
        player.GetComponent<PlayerInteractor>().PlayerMovement = true;
    }

    private IEnumerator FirstDialog()
    {
        dialogDoc2.GetComponent<SpriteRenderer>().enabled = true;
        dialogDoc2.GetComponent<SpriteRenderer>().sprite = dialogSprites[0];
        yield return waitForKeyPress(KeyCode.Space);
        dialogDoc2.GetComponent<SpriteRenderer>().sprite = null;

        dialogDoc1.GetComponent<SpriteRenderer>().enabled = true;
        dialogDoc1.GetComponent<SpriteRenderer>().sprite = dialogSprites[1];
        yield return waitForKeyPress(KeyCode.Space);
        dialogDoc1.GetComponent<SpriteRenderer>().sprite = null;

        dialogDoc2.GetComponent<SpriteRenderer>().enabled = true;
        dialogDoc2.GetComponent<SpriteRenderer>().sprite = dialogSprites[2];
        yield return waitForKeyPress(KeyCode.Space);
        dialogDoc2.GetComponent<SpriteRenderer>().sprite = null;

        dialogDoc1.GetComponent<SpriteRenderer>().enabled = true;
        dialogDoc1.GetComponent<SpriteRenderer>().sprite = dialogSprites[3];
        yield return waitForKeyPress(KeyCode.Space);
        dialogDoc1.GetComponent<SpriteRenderer>().sprite = null;

        dialogDoc2.GetComponent<SpriteRenderer>().enabled = true;
        dialogDoc2.GetComponent<SpriteRenderer>().sprite = dialogSprites[4];
        yield return waitForKeyPress(KeyCode.Space);
        dialogDoc2.GetComponent<SpriteRenderer>().sprite = null;

        dialogDoc1.GetComponent<SpriteRenderer>().enabled = true;
        dialogDoc1.GetComponent<SpriteRenderer>().sprite = dialogSprites[5];
        yield return waitForKeyPress(KeyCode.Space);
        dialogDoc1.GetComponent<SpriteRenderer>().sprite = null;

        dialogDoc1.GetComponent<SpriteRenderer>().enabled = true;
        dialogDoc1.GetComponent<SpriteRenderer>().sprite = dialogSprites[6];
        yield return waitForKeyPress(KeyCode.Space);
        dialogDoc1.GetComponent<SpriteRenderer>().sprite = null;

        dialogDoc1.GetComponent<SpriteRenderer>().enabled = true;
        dialogDoc1.GetComponent<SpriteRenderer>().sprite = dialogSprites[7];
        yield return waitForKeyPress(KeyCode.Space);
        dialogDoc1.GetComponent<SpriteRenderer>().sprite = null;

        dialogDoc2.GetComponent<SpriteRenderer>().enabled = true;
        dialogDoc2.GetComponent<SpriteRenderer>().sprite = dialogSprites[8];
        yield return waitForKeyPress(KeyCode.Space);
        dialogDoc2.GetComponent<SpriteRenderer>().sprite = null;

        dialogDoc2.GetComponent<SpriteRenderer>().enabled = true;
        dialogDoc2.GetComponent<SpriteRenderer>().sprite = dialogSprites[9];
        yield return waitForKeyPress(KeyCode.Space);
        dialogDoc2.GetComponent<SpriteRenderer>().sprite = null;

        dialogDoc2.GetComponent<SpriteRenderer>().enabled = true;
        dialogDoc2.GetComponent<SpriteRenderer>().sprite = dialogSprites[10];
        yield return waitForKeyPress(KeyCode.Space);
        dialogDoc2.GetComponent<SpriteRenderer>().sprite = null;

        dialogDoc2.GetComponent<SpriteRenderer>().enabled = true;
        dialogDoc2.GetComponent<SpriteRenderer>().sprite = dialogSprites[11];
        yield return waitForKeyPress(KeyCode.Space);
        dialogDoc2.GetComponent<SpriteRenderer>().sprite = null;

        dialogDoc2.GetComponent<SpriteRenderer>().enabled = true;
        dialogDoc2.GetComponent<SpriteRenderer>().sprite = dialogSprites[12];
        yield return waitForKeyPress(KeyCode.Space);
        dialogDoc2.GetComponent<SpriteRenderer>().sprite = null;

        ExitEvent();
    }



    /*StartCoroutine(DialogPlaces(dialogDoc2, 0));
    StartCoroutine(DialogPlaces(dialogDoc1, 1));
    StartCoroutine(DialogPlaces(dialogDoc2, 2));
    StartCoroutine(DialogPlaces(dialogDoc1, 3));
    StartCoroutine(DialogPlaces(dialogDoc2, 4));
    StartCoroutine(DialogPlaces(dialogDoc1, 5));
    StartCoroutine(DialogPlaces(dialogDoc1, 6));
    StartCoroutine(DialogPlaces(dialogDoc1, 7));
    print("Doc1 leaves");
    StartCoroutine(DialogPlaces(dialogDoc2, 8));
    StartCoroutine(DialogPlaces(dialogDoc2, 9));
    StartCoroutine(DialogPlaces(dialogDoc2, 10));
    StartCoroutine(DialogPlaces(dialogDoc2, 11));
    StartCoroutine(DialogPlaces(dialogDoc2, 12));*/

    /*private IEnumerator DialogPlaces(GameObject dialogbox, int arrayNumber)
    {
        dialogbox.GetComponent<SpriteRenderer>().enabled = true;
        dialogbox.GetComponent<SpriteRenderer>().sprite = dialoglist[arrayNumber];
        yield return waitForKeyPress(KeyCode.Space);
        dialogbox.GetComponent<SpriteRenderer>().sprite = null;
    }*/

    private IEnumerator waitForKeyPress(KeyCode key)
    {
        bool done = false;
        while (!done) // essentially a "while true", but with a bool to break out naturally
        {
            if (Input.GetKeyDown(key))
            {
                done = true;
            }
            yield return null;
        }
    }

}
