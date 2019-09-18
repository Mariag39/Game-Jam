using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    float pSpeed;

    // Use this for initialization
    void Start()
    {
        pSpeed = 0.1f;
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            LookAt(-1, 0);
            Move(-1, 0 );
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            LookAt(1, 0);
            Move(1, 0);

        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            LookAt(0, 1);
            Move(0, 1);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            LookAt(0, -1);
            Move(0, -1);
        }
    }

    void LookAt(int x, int z)
    {
        Vector3 pPlayer = this.transform.position;
        gameObject.transform.LookAt(new Vector3(pPlayer.x + x, pPlayer.y, pPlayer.z + z));

    }
    void Move(int x, int z)
    {
        Vector3 pPlayer = this.transform.position;
        if (x != 0)
            pPlayer.x += pSpeed * x;
        else
            pPlayer.z += pSpeed * z;

        this.transform.position = pPlayer;
    }
}
