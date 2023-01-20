using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] ParticleSystem projectile;

    private void Update()
    {
        if (Input.GetAxis("Fire1")!=0)
        {           
            projectile.Play();
        }
       
    }
}
