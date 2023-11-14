using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{


    private GameObject player;

    private void Awake()
    {
        //player = GameObject.FindGameObjectWithTag("Player");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //player.GetComponent<PlayerInteractor>().ForseSpawn = true;
            SceneManager.LoadScene("Hospital");
        }
 
        /*
        if (player.GetComponent<PlayerInteractor>().GameEnded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                player.GetComponent<PlayerInteractor>().ForseSpawn = true;
                SceneManager.LoadScene("Hospital");
            }
        }
        */
    }
}
