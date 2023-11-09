using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractor : MonoBehaviour
{

    [SerializeField] private bool have_key = false;
    [SerializeField] private bool have_cure = false;


    public bool KeyValue
    {
        get
        {
            return have_key;
        }
        set
        {
            have_key = value;
        }
    }

    public bool CureValue
    {
        get
        {
            return have_cure;
        }
        set
        {
            have_cure = value;
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
