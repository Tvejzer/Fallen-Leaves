using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class QuestLog : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Sprite ql1;
    [SerializeField] private Sprite ql2;
    [SerializeField] private Sprite ql3;
    private List<Sprite> sprites = new List<Sprite>();
    private int track = 0;

    private void Awake()
    {
        sprites.Add(ql1);
        sprites.Add(ql2);
        sprites.Add(ql3);
    }

    public void questLog(int Num)
    {
        if (Num >= track) 
        {
            GetComponent<Image>().enabled = true;
            GetComponent<Image>().sprite = sprites[Num];
            track++;
        }
    }
    public void questOff()
    {
        GetComponent<Image>().enabled = false;
    }

}
