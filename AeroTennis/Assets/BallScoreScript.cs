using UnityEngine;
using System.Collections;

public class BallScoreScript : MonoBehaviour
{
    private managmentScrip gameManager;
    private AudioManager2 audioManager;


    private bool cooldown = false;
    private void Start()
    {
        // Get a reference to the TennisGameManager component
        gameManager = FindObjectOfType<managmentScrip>();
        audioManager = FindObjectOfType<AudioManager2>();
    }

    // This method is called when the ball collides with a goal collider
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ScoreArea2") && !cooldown)
        {
            gameManager.ScorePoint(PlayerID.Player2);
            audioManager.PlaySound("splash", .5f);
            transform.position = new Vector3(0, -10, 0);
        }
        else if (other.CompareTag("ScoreArea1"))
        {
            gameManager.ScorePoint(PlayerID.Player1);
            audioManager.PlaySound("splash", .5f);
            transform.position = new Vector3(0, -10, 0);
        }
    }



    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
                audioManager.PlaySound("hitsand", .5f);
        }
    }
    
 
}