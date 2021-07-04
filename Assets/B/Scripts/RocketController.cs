using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour {

    public GameObject children;

    void Update(){
        Debug.Log(this.transform.position.x);
        if (Input.GetKey(KeyCode.LeftArrow) && !(this.transform.position.x <= -8))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow) && !(this.transform.position.x >= 8))
        {
            transform.Translate(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow) && !(this.transform.position.y >= 3))
        {
            transform.Translate(0, 0.1f, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow) && !(this.transform.position.y <= -3))
        {
            transform.Translate(0, -0.1f, 0);
        }



    }
}
