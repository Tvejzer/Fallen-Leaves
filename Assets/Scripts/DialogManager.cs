using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    
    
    
    private List<Sprite> DialogList;
    private GameObject player;
    private SoundManager soundManager;
    private MoverManager moverManager;
    private Dictionary<int, GameObject> dialogDict = new();
    private Dictionary<int, List<int>> dialogInfo = new();
    private int button;


    [SerializeField] private GameObject dialogDoc1;
    [SerializeField] private GameObject dialogDoc2;
    [SerializeField] private GameObject dialogZorka;
    [SerializeField] private GameObject specialZorka;
    [SerializeField] private GameObject dialogHom;
    [SerializeField] private List<Sprite> specialSprites;

    private void LoadResources()
    {
        DialogList = new List<Sprite>(Resources.LoadAll<Sprite>("DialogSprites"));
        player = GameObject.FindGameObjectWithTag("Player");
        soundManager = FindObjectOfType<SoundManager>();
        moverManager = FindObjectOfType<MoverManager>();
    }

    private void DialogInformation()
    {
        // "TriggerID", int First Dialog Sprite, int Last Dialog Sprite, bool If Was Played, int Special Event Trigger, Special Event ID
        dialogInfo.Add(0, new List<int> { 0, 12, 0, 7, 1 });
        dialogInfo.Add(1, new List<int> { 13, 15, 0, 15, 2 });
        dialogInfo.Add(2, new List<int> { 16, 16, 0, 16, 3 });
        dialogInfo.Add(3, new List<int> { 17, 17, 0, 17, 3 });
        dialogInfo.Add(4, new List<int> { 18, 19, 0, 19, 4 });
    }


    private void DialogInitialisation()
    {
        dialogDict.Add(0, dialogDoc2);
        dialogDict.Add(1, dialogDoc1);
        dialogDict.Add(2, dialogDoc2);
        dialogDict.Add(3, dialogDoc1);
        dialogDict.Add(4, dialogDoc2);
        dialogDict.Add(5, dialogDoc1);
        dialogDict.Add(6, dialogDoc1);
        dialogDict.Add(7, dialogDoc1);

        dialogDict.Add(8, dialogDoc2);
        dialogDict.Add(9, dialogDoc2);
        dialogDict.Add(10, dialogDoc2);
        dialogDict.Add(11, dialogDoc2);
        dialogDict.Add(12, dialogDoc2);

        dialogDict.Add(13, dialogHom);
        dialogDict.Add(14, dialogZorka);
        dialogDict.Add(15, dialogHom);

        dialogDict.Add(16, dialogZorka);
        dialogDict.Add(17, dialogZorka);

        dialogDict.Add(18, dialogHom);
        dialogDict.Add(19, dialogHom);
    }


    private void Awake()
    {
        DialogInformation();
        DialogInitialisation();
        LoadResources();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }







    public void StartEvent(int EventID)
    {

        switch (EventID)
        {
            case 1:
                print("Doc1 leaves");
                moverManager.Event1();
                break;
            case 2:
                StartCoroutine(Event2());
                break;
            case 3:
                StartDialog(4);
                break;
            case 4:
                Event4();
                break;
            case 5:
                break;
        }
    }

    private void StartDialog (int TrigerID)
    {
        if (dialogInfo[TrigerID][2] == 0)
        {
            StartCoroutine(DialogDisplay(TrigerID));
        }
    }
    public void OnTrigger(int EventID)
    {
        switch (EventID)
        {
            case 0:
                StartDialog(EventID);
                break;
            case 1:
                StartDialog(EventID);
                break;
            case 6:
                soundManager.SfxDeath();
                player.GetComponent<PlayerInteractor>().ChapterProgresss = 8;
                player.GetComponent<PlayerInteractor>().CureValue = false;
                break;
            case 7:
                soundManager.SfxHvala();
                player.GetComponent<PlayerInteractor>().ChapterProgresss = 8;
                player.GetComponent<PlayerInteractor>().CureValue = false;
                break;
        }
    }




    private IEnumerator DialogDisplay(int TrigerID)
    {

        bool GoToExit = true;
        player.GetComponent<PlayerInteractor>().PlayerMovement = false;
        for (int i = dialogInfo[TrigerID][0]; i <= dialogInfo[TrigerID][1]; i++)
        {
            dialogDict[i].GetComponent<SpriteRenderer>().enabled = true;
            dialogDict[i].GetComponent<SpriteRenderer>().sprite = DialogList[i];
            soundManager.DialogVoice(i);
            yield return waitForKeyPress(KeyCode.Space);
            soundManager.DialogStop();
            dialogDict[i].GetComponent<SpriteRenderer>().sprite = null;
            if (dialogInfo[TrigerID][3] == i)
            {
                StartEvent(dialogInfo[TrigerID][4]);
                GoToExit = false;
            }
            else GoToExit = true;

        }

        if (GoToExit)
        {
            ExitEvent(TrigerID);
        }
    }

    private void ExitEvent(int TrigerID)
    {
        player.GetComponent<PlayerInteractor>().PlayerMovement = true;
        dialogInfo[TrigerID][2] = 1;
        player.GetComponent<PlayerInteractor>().ChapterProgresss = TrigerID+1;
    }

    public IEnumerator waitForKeyPress(KeyCode key)
    {
        bool done = false;
        while (!done)
        {
            if (Input.GetKeyDown(key))
            {
                done = true;
            }
            yield return null;
        }
    }

    public IEnumerator Event2()
    {
        player.GetComponent<PlayerInteractor>().PlayerMovement = false;
        specialZorka.GetComponent<SpriteRenderer>().enabled = true;
        specialZorka.GetComponent<SpriteRenderer>().sprite = specialSprites[0];
        yield return PressTheeseKey(KeyCode.Alpha1, KeyCode.Alpha2);
        specialZorka.GetComponent<SpriteRenderer>().sprite = null;
        if (button ==1)
        {
            StartDialog(2);
        }
        else if (button ==2)
        {
            StartDialog(3);
        }
    }

    public IEnumerator PressTheeseKey(KeyCode key1,KeyCode key2)
    {
        bool done = false;
        while (!done)
        {
            if (Input.GetKeyDown(key1))
            {
                done = true;
                button = 1;
            }
            if (Input.GetKeyDown(key2))
            {
                done = true;
                button = 2;
            }
            yield return null;
        }
    }

    public void Event4()
    {
        player.GetComponent<PlayerInteractor>().KeyValue = true;
        soundManager.SfxPickUp();
        ExitEvent(4);
    }

}
