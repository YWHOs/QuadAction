using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartZone : MonoBehaviour
{
    public GameManager manager;

    void OnTriggerEnter(Collider _other)
    {
        if (_other.gameObject.tag == "Player")
            manager.StageStart();
    }
}
