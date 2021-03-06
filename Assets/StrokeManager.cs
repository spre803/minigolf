﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrokeManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindPlayerBall();
    }

    Rigidbody playerBallRB;
    bool doWhack = false;


    private void FindPlayerBall()
    {
        //problem: when finding objects with tags, you can make typos, when u do it with type, it wont compile cause it doesnt find the right type
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        if(go == null)
        {
            Debug.LogError("Couldnt find the ball");
        }
        playerBallRB = go.GetComponent<Rigidbody>();

        if(playerBallRB == null)
        {
            Debug.LogError("Ball has no Rigidboy");
        }
    }

    // Update is called once per visual frame -- this for inputs
    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            doWhack = true;
        }
    }

    // FixedUpdate runs on every tick of the physics engine, use this for manipulation
    void FixedUpdate()
    {

        if(playerBallRB == null)
        {
            // might not be an error -- maybe the ball fell out of bounds, got deleted, and hasnt returned yet
            return;
        }

        if(doWhack == true)
        {
            doWhack = false;
            //Whack dat ball bruh
            Vector3 forceVec = new Vector3(0, 0, 10f);
            playerBallRB.AddForce(forceVec, ForceMode.Impulse);
        }
    }
}
