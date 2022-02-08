using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour{

    public float speed = 5f;
    public int player1Score;
    public int player2Score;

    
    

    // Start is called before the first frame update
    void Start()
    {
        float sx = Random.Range(0,2) == 0 ? -1 : 1;
        float sy = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector3(speed * sx, speed * sy, 0f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.name == "Left_Wall")
    //    {
    //        player2Score++;
    //        Debug.Log("Player two has scored! Score: " + player2Score );
    //    }
    //    if (collision.gameObject.name == "Right_Wall")
    //    {
    //        player1Score++;
    //        Debug.Log("Player one has scored! Score: " + player1Score);
    //    }
    //}
}
