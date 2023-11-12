using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverManager : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 20f;
    [SerializeField] private GameObject whatToMove1;
    [SerializeField] private GameObject whereToMove11;
    [SerializeField] private GameObject whereToMove12;
    [SerializeField] private GameObject whereToMove13;
    [SerializeField] private bool toMove1 = false;
    [SerializeField] private bool toMove2 = false;
    [SerializeField] private bool toMove3 = false;

    private void Awake()
    {

    }


    void Start()
    {
    }

    public void Event1()
    {
        whatToMove1.transform.localScale = new Vector3(1f, 1);
        toMove1 = true;
    }

    private void Mover(Vector3 start, Vector3 target)
    {
        whatToMove1.transform.position = Vector3.MoveTowards(start, target, moveSpeed * Time.deltaTime);
    }



    void FixedUpdate()
    {


        if (toMove1)
        {
            Mover(whatToMove1.transform.position, whereToMove11.transform.position);
        }
        if (whatToMove1.transform.position == whereToMove11.transform.position)
        {
            toMove1 = false;
            toMove2 = true;
        }
        
        
        if (toMove2)
        {
            Mover(whatToMove1.transform.position, whereToMove12.transform.position);
        }
        if (whatToMove1.transform.position == whereToMove12.transform.position)
        {
            toMove2 = false;
            toMove3 = true;
        }

        if (toMove3)
        {
            Mover(whatToMove1.transform.position, whereToMove13.transform.position);
        }
        if (whatToMove1.transform.position == whereToMove13.transform.position)
        {
            toMove3 = false;
        }
    }
}