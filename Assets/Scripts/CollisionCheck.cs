using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionCheck : MonoBehaviour {

    public Movement playerMovement;
    bool touchedFinish = false;
    static string[] scenes = { "L1", "L2", "L3", "Start"};
    static int index = 0;
    private void FixedUpdate()
    {
        if (touchedFinish && playerMovement.rb.position.y < 4)
        {
            Debug.Log((int)playerMovement.rb.position.y);
            gameOver();
        }
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            gameOver();
        }
        if (collision.collider.tag == "Finish")
        {
            playerMovement.distance.text = "Level Complete!";
            playerMovement.distance.color = Color.green;
            playerMovement.enabled = false;
            playerMovement.rb.AddTorque(5000, 0, 0);
            playerMovement.rb.AddForce(0, 5000, 5000);
            //touchedFinish = true;
            this.enabled = false;
            index++;
            if (index < scenes.Length)
            {
                Invoke("Restart", 4);
            }
            else
            { 
                playerMovement.distance.text = "Game Complete!";
            }
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        touchedFinish = true;
    }

    private void gameOver()
    {
        
        playerMovement.distance.color = Color.red;
        playerMovement.distance.text = "Game Over";
        playerMovement.enabled = false;
        Invoke("Restart", 2);
        //   SceneManager.LoadScene("L1");
    }

    public void Restart()
    {
        string currentscene = scenes[index];
        SceneManager.LoadScene(currentscene);
    }
}
