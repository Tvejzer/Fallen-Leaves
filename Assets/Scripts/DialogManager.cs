using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogManager : MonoBehaviour
{
    
    
    
    private List<Sprite> DialogList;
    private GameObject player;
    private SoundManager soundManager;
    private MoverManager moverManager;
    private Dictionary<int, GameObject> dialogDict = new();
    private Dictionary<int, List<int>> dialogInfo = new();
    private int button;
    private QuestLog questLog;

    [SerializeField] private GameObject dialogDoc1;
    [SerializeField] private GameObject dialogDoc2;
    [SerializeField] private GameObject dialogZorka;
    [SerializeField] private GameObject dialogAuh;
    [SerializeField] private GameObject dialogSerb;
    [SerializeField] private GameObject specialZorka;
    [SerializeField] private GameObject dialogHom;
    [SerializeField] private List<Sprite> specialSprites;

    private void LoadResources()
    {
        DialogList = new List<Sprite>(Resources.LoadAll<Sprite>("DialogSprites"));
        player = GameObject.FindGameObjectWithTag("Player");
        soundManager = FindObjectOfType<SoundManager>();
        moverManager = FindObjectOfType<MoverManager>();
        questLog = FindObjectOfType<QuestLog>();
    }

    private void DialogInformation()
    {
        // "TriggerID", int First Dialog Sprite, int Last Dialog Sprite, bool If Was Played, int Special Event Trigger, Special Event ID
        //dialogInfo.Add(0, new List<int> { 0 , 0 , 0 , 0});
        dialogInfo.Add(0, new List<int> { 0, 12, 0, 7, 1 });
        dialogInfo.Add(1, new List<int> { 13, 15, 0, 15, 2 });
        dialogInfo.Add(2, new List<int> { 16, 16, 0, 16, 3 });
        dialogInfo.Add(3, new List<int> { 17, 17, 0, 17, 3 });
        dialogInfo.Add(4, new List<int> { 18, 19, 0, 19, 4 });
        
        dialogInfo.Add(5, new List<int> { 20, 20, 0, 20, 5 });
        dialogInfo.Add(6, new List<int> { 21, 21, 0, 21, 6 });
        dialogInfo.Add(7, new List<int> { 22, 22, 0, 22, 7 });
        dialogInfo.Add(8, new List<int> { 23, 23, 0, 23, 0 });
        dialogInfo.Add(9, new List<int> { 24, 24, 0, 24, 8 });
        dialogInfo.Add(10, new List<int> { 25, 26, 0, 26, 9 });
        dialogInfo.Add(11, new List<int> { 27, 29, 0, 29, 10 });

        dialogInfo.Add(12, new List<int> { 30, 30, 0, 30, 11 });
        dialogInfo.Add(13, new List<int> { 31, 31, 0, 31, 12 });
        dialogInfo.Add(14, new List<int> { 32, 32, 0, 32, 13 });
        dialogInfo.Add(15, new List<int> { 33, 33, 0, 33, 0 });
        dialogInfo.Add(16, new List<int> { 34, 34, 0, 34, 14 });
        dialogInfo.Add(17, new List<int> { 35, 36, 0, 36, 15 });
        dialogInfo.Add(18, new List<int> { 36, 38, 0, 38, 10 });

    }



    private void DialogInitialisation()
    {
        // d0
        dialogDict.Add(0, dialogDoc2);
        dialogDict.Add(1, dialogDoc1);
        dialogDict.Add(2, dialogDoc2);
        dialogDict.Add(3, dialogDoc1);
        dialogDict.Add(4, dialogDoc2);
        dialogDict.Add(5, dialogDoc1);
        dialogDict.Add(6, dialogDoc1);
        dialogDict.Add(7, dialogDoc1);
        // e1
        dialogDict.Add(8, dialogDoc2);
        dialogDict.Add(9, dialogDoc2);
        dialogDict.Add(10, dialogDoc2);
        dialogDict.Add(11, dialogDoc2);
        dialogDict.Add(12, dialogDoc2);
        // d1
        dialogDict.Add(13, dialogHom);
        dialogDict.Add(14, dialogZorka);
        dialogDict.Add(15, dialogHom);
        // e2
        // d2
        dialogDict.Add(16, dialogZorka);
        // d3
        dialogDict.Add(17, dialogZorka);
        // d4
        dialogDict.Add(18, dialogHom);
        dialogDict.Add(19, dialogHom);


        // d5
        dialogDict.Add(20, dialogDoc1);
        // e5
        // d6
        dialogDict.Add(21, dialogZorka);
        // d7
        dialogDict.Add(22, dialogZorka);
        // e6
        // d8
        dialogDict.Add(23, dialogDoc1);
        // d9
        dialogDict.Add(24, dialogAuh);
        dialogDict.Add(25, dialogDoc2);
        dialogDict.Add(26, dialogDoc1);
        //e7
        dialogDict.Add(27, dialogHom);
        dialogDict.Add(28, dialogHom);
        dialogDict.Add(29, dialogHom);

        // d10
        dialogDict.Add(30, dialogDoc2);
        // e9
        // d11
        dialogDict.Add(31, dialogZorka);
        // d12
        dialogDict.Add(32, dialogZorka);
        // d13
        dialogDict.Add(33, dialogDoc2);
        // d14
        dialogDict.Add(34, dialogSerb);
        dialogDict.Add(35, dialogDoc1);
        dialogDict.Add(36, dialogDoc1);
        // e10
        dialogDict.Add(37, dialogHom);
        dialogDict.Add(38, dialogHom);
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
            case 0:
                player.GetComponent<PlayerInteractor>().PlayerMovement = true;
                break;
            case 1:
                questLog.questLog(0);
                moverManager.Event1();
                break;
            case 2:
                StartCoroutine(EventChose(0,2,3,0));
                break;
            case 3:
                StartDialog(4);
                break;
            case 4:
                Event4();
                break;
            case 5:
                StartCoroutine(EventChose(1,6,7,1));
                break;
            case 6:
                questLog.questOff();
                StartDialog(9);
                break; 
            case 7:
                StartDialog(8);
                break;
            case 8:
                moverManager.Event6();
                StartDialog(10);
                break;
            case 9:
                moverManager.Event7();
                StartDialog(11);
                break;
            case 10:
                print("The End");
                player.GetComponent<PlayerInteractor>().GameEnded = true;
                SceneManager.LoadScene("The End");
                break;
            case 11:
                StartCoroutine(EventChose(1,13,14,3));
                break;
            case 12:
                StartDialog(16);
                break; 
            case 13:
                questLog.questOff();
                StartDialog(15);
                break; 
            case 14:
                moverManager.Event8();
                StartDialog(17);
                break;
            case 15:
                moverManager.Event9();
                StartDialog(18);
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
                StartDialog(5);
                break;
            case 7:
                StartDialog(12);
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

    /*
    public IEnumerator waitForKeyPress(KeyCode key)
    {
        bool done = false;
        while (!done)
        {
            if (player.GetComponent<PlayerMover>().InteractPressed)
            {
                done = true;
            }
            yield return null;
        }
    }
    */



    public void Event4()
    {
        player.GetComponent<PlayerInteractor>().KeyValue = true;
        soundManager.SfxPickUp();
        questLog.questLog(1);
        ExitEvent(4);
    }

    public IEnumerator EventChose(int Sprite, int Button1, int Button2, int TriggerChange)
    {
        player.GetComponent<PlayerInteractor>().PlayerMovement = false;
        specialZorka.GetComponent<SpriteRenderer>().enabled = true;
        specialZorka.GetComponent<SpriteRenderer>().sprite = specialSprites[Sprite];
        yield return PressTheeseKey(KeyCode.Alpha1, KeyCode.Alpha2);
        specialZorka.GetComponent<SpriteRenderer>().sprite = null;
        if (button == 1)
        {
            player.GetComponent<PlayerInteractor>().ChapterProgresss += TriggerChange;
            StartDialog(Button1);
        }
        else if (button == 2)
        {
            //player.GetComponent<PlayerInteractor>().ChapterProgresss += TriggerChange;
            StartDialog(Button2);
        }
        

    }

    public IEnumerator PressTheeseKey(KeyCode key1, KeyCode key2)
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

    public string Test { get; set; } = "true";

}
