using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestWeaponCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Collision Entered:: " + collider.tag);
    }
}
