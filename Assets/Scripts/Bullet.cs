using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage;
    public bool isMelee;
    public bool isRock;

    void OnCollisionEnter(Collision _collision)
    {
        if(!isRock && _collision.gameObject.tag == "Floor")
        {
            Destroy(gameObject, 3);
        }
    }
    void OnTriggerEnter(Collider _other)
    {
        if (!isMelee && _other.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
