using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private Rigidbody2D pacman;

    public bool moveup, movedown, moveright, moveleft;
    public float speed;
    


private void Start() {
    moveup = false;
    movedown = false;
    moveright = false;
    moveleft = false;
}
    private void FixedUpdate() {
        if (moveup == true){
            MoveUp();
            moveup = false;
        }
        else if (movedown == true){
            MoveDown();
            movedown = false;
        }
        else if (moveright == true){
            MoveRight();
            moveright = false;
        }
        else if (moveleft == true){
            MoveLeft();
            moveleft = false;
        }
        
    }

    public void MoveUp(){
        moveup = true;
        pacman.velocity = Vector2.up * speed;
    }

    public void MoveDown(){
        movedown = true;
        pacman.velocity = Vector2.down * speed;
    }

    public void MoveLeft(){
        moveleft = true;
        pacman.velocity = Vector2.left * speed;
        pacman.transform.localScale = new Vector2(-1f, 1f);
    }

    public void MoveRight(){
        moveright = true;
        pacman.velocity = Vector2.right * speed;
        pacman.transform.localScale = new Vector2(1f, 1f);

    }
    
}
