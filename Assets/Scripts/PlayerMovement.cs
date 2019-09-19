﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float pSpeed;
    public int player = 1;
    private bool l;
    private bool r;
    private bool u;
    private bool d;
    public GameObject ball;

    private string m_inputs;

    // Use this for initialization
    void Start() {
        pSpeed = 0.1f;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == ball.tag)
        {
            Debug.Log("pum");
        }
    }


    private void OnCollisionExit(Collision collision)
    {
        //if (collision.gameObject.tag == ball.tag)
        //{
        //    Debug.Log("pum");
        //}
    }

    void Update() {
        movementInfo();
        
    }

    void movementInfo() {
        if (player == 1)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {  //Izquierda
                Move(-1, 0);
                l = true;
            }
            else l = false;
            if (Input.GetKey(KeyCode.RightArrow))   //Derecha
            {
                LookAt(1, 0);
                Move(1, 0);
                r = true;
            }
            else r = false;
            if (Input.GetKey(KeyCode.UpArrow))  //Arriba
            {

                Move(0, 1);
                u = true;
            }
            else u = false;
            if (Input.GetKey(KeyCode.DownArrow))    //Abajo
            {
                LookAt(0, -1);
                Move(0, -1);
                d = true;
            }
            else d = false;
        }
        else
        {
            if (Input.GetKey(KeyCode.A))
            {  //Izquierda
                Move(-1, 0);
                l = true;
            }
            else l = false;
            if (Input.GetKey(KeyCode.D))   //Derecha
            {
                LookAt(1, 0);
                Move(1, 0);
                r = true;
            }
            else r = false;
            if (Input.GetKey(KeyCode.W))  //Arriba
            {

                Move(0, 1);
                u = true;
            }
            else u = false;
            if (Input.GetKey(KeyCode.S))    //Abajo
            {
                LookAt(0, -1);
                Move(0, -1);
                d = true;
            }
            else d = false;
        }

        // orientacion
        if (l && u) LookAt(-1, 1);
        else if (l && d) LookAt(-1, -1);
        else if (r && u) LookAt(1, 1);
        else if (r && d) LookAt(1, -1);
        else if (u) LookAt(0, 1);
        else if (d) LookAt(0, -1);
        else if (l) LookAt(-1, 0);
        else if (r) LookAt(1, 0);
       
    }

    void LookAt(int x, int z) {
        Vector3 pPlayer = this.transform.position;
        gameObject.transform.LookAt(new Vector3(pPlayer.x + x, pPlayer.y, pPlayer.z + z));
        
    }

    void Move(int x, int z) {
        Vector3 pPlayer = this.transform.position;
        if (x != 0)
            pPlayer.x += pSpeed * x;
        else
            pPlayer.z += pSpeed * z;

        this.transform.position = pPlayer;
        
    }
}
