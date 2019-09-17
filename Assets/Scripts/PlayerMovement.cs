using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    //Para que mire a la izqd -> Y = 90
    //                   der  -> Y = -90
    //                   abj  -> Y = 0
    //                   arr  -> Y = 180
    void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) 
        {
            //transform.Rotate(Vector3.down, 90f);
            gameObject.transform.LookAt(Vector3.down);
            //gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, posFin, 0.3f);
        }
    }
}
