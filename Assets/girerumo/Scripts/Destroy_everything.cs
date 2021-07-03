using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_everything : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }

}
