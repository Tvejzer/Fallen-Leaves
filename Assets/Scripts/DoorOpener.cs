using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : ObjectManager
{

    [SerializeField] private float maxRotation = 120f;
    [SerializeField] private GameObject door;
    [SerializeField] private bool opened = false;
    private bool have_key;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        have_key = Player.GetComponent<PlayerInteractor>().KeyValue;

        if (PlayerCollision && have_key)
        {
            if (!opened) {Open();}
        }
    }

    private void Open()
    {
        SoundManager.SfxDoor();
        door.transform.Rotate(0.0f, 0.0f, maxRotation);
        opened = true;
    }

}
