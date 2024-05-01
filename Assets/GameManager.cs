using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject dot;
    public ScoreScript scoreScript;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        eat();
    }

    void eat()
    {
        Vector3 newPosition = new Vector3();
        newPosition.Set(UnityEngine.Random.Range(0, 5), UnityEngine.Random.Range(0, 5), 0);

        if (player.transform.position == dot.transform.position) {
            dot.transform.position = newPosition;
            changeColor();
            scoreScript.addScorePoint();
        }
    }

    void changeColor()
    {
        Color playerColor = player.GetComponent<SpriteRenderer>().color;
        if(playerColor == Color.blue) {
            player.GetComponent<SpriteRenderer>().color = Color.white;
        } else
        {
            player.GetComponent<SpriteRenderer>().color = Color.blue;
        }
        
    }
}
