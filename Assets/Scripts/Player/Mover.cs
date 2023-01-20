using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float playerMoveSpeed;
    [SerializeField] float clampPlayerMove;
   
    void Update()
    {
        if (player == null) return;
        Vector3 rawMove = new Vector3(0,Input.GetAxis("Vertical"));

        float rawPlayerYPos = Mathf.Clamp(player.position.y + rawMove.y * playerMoveSpeed * Time.deltaTime,
            -clampPlayerMove, clampPlayerMove);

        player.position = new Vector3(player.position.x, rawPlayerYPos);


    }
}
