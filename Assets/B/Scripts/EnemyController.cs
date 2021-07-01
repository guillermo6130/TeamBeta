using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

       float fallSpeed;
       float rotSpeed;

    // Start is called before the first frame update
    void Start() {
          this.fallSpeed = 0.01f + 0.1f * Random.value;
          this.rotSpeed = 6f + 3f * Random.value;
    }

    // Update is called once per frame
    void Update() {
          transform.Translate( 0, -fallSpeed, 0, Space.World);

          transform.Rotate(0, rotSpeed, 0 );

          if (transform.position.y < -8.0f) {
                Destroy (gameObject);
          }
    }
}
