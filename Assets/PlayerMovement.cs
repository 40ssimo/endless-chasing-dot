using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    public int move;
    public int boundary;
    // Start is called before the first frame update
    void Start()
    {
        player.GetComponent<SpriteRenderer>().color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }

    void movement(){

        if (Input.GetKeyDown(KeyCode.UpArrow) && (player.transform.position.y < boundary)) 
        {
            player.transform.position += Vector3.up * move;
            Debug.Log("Up");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && (player.transform.position.y > boundary * -1))
        {
            player.transform.position += Vector3.down * move;
            Debug.Log("Down");
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && (player.transform.position.x > boundary * -1))
        {
            player.transform.position += Vector3.left * move;
            Debug.Log("Left");
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && (player.transform.position.x < boundary))
        {
            player.transform.position += Vector3.right * move;
            Debug.Log("Right");
        }

    }

}
