using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : ObjectManager
{

    // Update is called once per frame
    void Update()
    {
        if (PlayerCollision)
        {
            Player.GetComponent<PlayerInteractor>().KeyValue = true;
            QuestLog.questLog(1);
            SoundManager.SfxPickUp();

            if (Destroyy)
            {
                Destroy(gameObject);
            }
        }
    }
}
