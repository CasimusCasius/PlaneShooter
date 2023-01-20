using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float playerMoveSpeed;
   
    void Update()
    {
        if (player == null) return;
        Vector3 rawMove = new Vector3(0,Input.GetAxis("Vertical"));

        player.position = player.position + rawMove*playerMoveSpeed*Time.deltaTime;
    }
}
