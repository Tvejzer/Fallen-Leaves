using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : ObjectManager
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerCollision)
        {
            Player.GetComponent<PlayerInteractor>().KeyValue = true;
            SoundManager.SfxPickUp();

            if (Destroyy)
            {
                Destroy(gameObject);
            }
        }
    }
}
