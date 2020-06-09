using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        int damage;
        GameObject otherObject = otherCollider.gameObject;

        if (otherObject.tag == "Lizard")
        {
            damage = 20;
        }
        else if (otherObject.tag == "Fox")
        {
            damage = 40;
        }
        else
        {
            damage = 100;
        }

        FindObjectOfType<HealthBar>().TakeLife(damage);
        Destroy(otherObject);
    }
}
