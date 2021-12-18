using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int collisionDamage = 2;
    public string collisionTag;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == collisionTag)
        {
            Hearts health = collision.gameObject.GetComponent<Hearts>();
            health.TakeHit(collisionDamage);
        }
    }
}
