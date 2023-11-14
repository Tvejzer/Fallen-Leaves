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
    [SerializeField] private GameObject dialogFix;
    [SerializeField] private bool toMove1 = false;
    [SerializeField] private bool toMove2 = false;
    [SerializeField] private bool toMove3 = false;

    [SerializeField] private GameObject whatToMove6;
    [SerializeField] private GameObject fromWhereMove6;
    [SerializeField] private GameObject whereToMove6;
    [SerializeField] private bool toMove6 = false;

    [SerializeField] private GameObject whatToMove7;
    [SerializeField] private GameObject fromWhereMove7;
    [SerializeField] private GameObject whereToMove7;
    [SerializeField] private bool toMove7 = false;

    [SerializeField] private GameObject whatToMove8;
    [SerializeField] private GameObject fromWhereMove8;
    [SerializeField] private GameObject whereToMove8;
    [SerializeField] private bool toMove8 = false;

    [SerializeField] private GameObject whatToMove9;
    [SerializeField] private GameObject fromWhereMove9;
    [SerializeField] private GameObject whereToMove9;
    [SerializeField] private bool toMove9 = false;

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
        dialogFix.transform.localScale = new Vector3(1f, 1);
    }
    public void Event9()
    {
        whatToMove9.transform.position = fromWhereMove9.transform.position;
        toMove9 = true;
    }

    public void Event8()
    {
        whatToMove8.transform.position = fromWhereMove8.transform.position;
        whatToMove8.GetComponent<BoxCollider2D>().enabled = false;
        toMove8 = true;
    }
    public void Event7()
    {
        whatToMove7.transform.position = fromWhereMove7.transform.position;
        toMove7 = true;
    }
    public void Event6()
    {
        whatToMove6.transform.position = fromWhereMove6.transform.position;
        toMove6 = true;
    }

    private void Mover(GameObject movable,Vector3 start, Vector3 target)
    {
        movable.transform.position = Vector3.MoveTowards(start, target, moveSpeed * Time.deltaTime);
    }



    void FixedUpdate()
    {


        if (toMove1)
        {
            Mover(whatToMove1, whatToMove1.transform.position, whereToMove11.transform.position);
        }
        if (whatToMove1.transform.position == whereToMove11.transform.position)
        {
            toMove1 = false;
            toMove2 = true;
        }
        
        
        if (toMove2)
        {
            Mover(whatToMove1, whatToMove1.transform.position, whereToMove12.transform.position);
        }
        if (whatToMove1.transform.position == whereToMove12.transform.position)
        {
            toMove2 = false;
            toMove3 = true;
        }

        if (toMove3)
        {
            Mover(whatToMove1, whatToMove1.transform.position, whereToMove13.transform.position);
        }
        if (whatToMove1.transform.position == whereToMove13.transform.position)
        {
            toMove3 = false;
        }

        if (toMove6)
        {
            Mover(whatToMove6, whatToMove6.transform.position, whereToMove6.transform.position);
        }
        if (whatToMove6.transform.position == whereToMove6.transform.position)
        {
            toMove6 = false;
        }

        if (toMove7)
        {
            Mover(whatToMove7, whatToMove7.transform.position, whereToMove7.transform.position);
        }
        if (whatToMove7.transform.position == whereToMove7.transform.position)
        {
            toMove7 = false;
        }

        if (toMove8)
        {
            Mover(whatToMove8, whatToMove8.transform.position, whereToMove8.transform.position);
        }
        if (whatToMove8.transform.position == whereToMove8.transform.position)
        {
            toMove8 = false;
        }

        if (toMove9)
        {
            Mover(whatToMove9, whatToMove9.transform.position, whereToMove9.transform.position);
        }
        if (whatToMove9.transform.position == whereToMove9.transform.position)
        {
            toMove9 = false;
        }
    }
}