using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy : MonoBehaviour
{
    public int Energy_amount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        /*Debug.Log(other.name + "Enter");*/
        
        if (other.tag == "Player")
        {
            Player_Energy player = other.GetComponentInParent<Player_Energy>();
            player.addEnergy(Energy_amount);

            Destroy(this.gameObject);
        }
    }

    private void OnDestroy()
    {
        
    }
}
