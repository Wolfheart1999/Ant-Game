using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant_Move : MonoBehaviour {

    public int playerSpeed = 10;
    public bool facingRight = true;
    public int playerJumpPower = 1250;
    public float moveX;

    // Update is called once per frame
    void Update() {
        PlayerMove();
    }
    void PlayerMove() {
        //CONTROlS
        moveX = Input.GetAxis("Horizontal");
        //ANIMATIONS
        //PLAYER DIRECTION
        //PHYSICS
}
    void Jump();
    //JUMPING CODE

}
