using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSystem : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    
    {
        Debug.Log("destroyed");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(gameObject.name + " destroyed");
    }
}
