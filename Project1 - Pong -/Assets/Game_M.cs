using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_M : MonoBehaviour
{

    public GameObject ballPf;

    public float xBound = 3f;
    public float yBound = 3f;
    public float ballSpeed = 5f;
    public float respawnDelay = 2f;
    public int player1Score;
    public int player2Score;

    public Vector3 swapnPoint;

    WaitForSeconds oneSec;
    WaitForSeconds delay;

    public float restartDelay = 1f;
         
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Left_Wall")
        {
            player2Score++;
            Debug.Log("Player two has scored! Score: " + player2Score);
            transform.position = swapnPoint;
        }
        if (collision.gameObject.name == "Right_Wall")
        {
            player1Score++;
            Debug.Log("Player one has scored! Score: " + player1Score);
            transform.position = swapnPoint;
        }

        // we need to check and see if any of the points for the players reach 11
        // if so then we need to restart the game
        if (player1Score == 11 || player2Score == 11)
        {
            // we have to restart the game b/c ether one of the player has won the game
            if (player1Score == 11)
            {
                Debug.Log("Game Over Left Paddle Wins");
            }
            if (player2Score == 11)
            {
                Debug.Log("Game Over Right Paddle Wins");
            }


            Invoke("Restart", respawnDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
