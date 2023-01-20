using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] float enemySpeed = 3f;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * -1 * enemySpeed * Time.deltaTime;   
    }
}
