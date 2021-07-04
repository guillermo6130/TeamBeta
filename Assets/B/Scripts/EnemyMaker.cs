using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMaker : MonoBehaviour {

       public GameObject Enemy_1;

    // Start is called before the first frame update
    void Start() {
          InvokeRepeating ("MakeEnemy", 1, 1);
    }

    // Update is called once per frame
    void MakeEnemy() {
          Instantiate (Enemy_1, new Vector3 (-8f + 16 * Random.value, 4, 0), Quaternion.identity);
    }
}
