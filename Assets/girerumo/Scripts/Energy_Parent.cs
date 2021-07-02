using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy_Parent : MonoBehaviour
{
    public GameObject Energy_1;
    public GameObject Energy_5;
    public GameObject Energy_10;
    public GameObject Energy_50;
    public GameObject Energy_100;
    private GameObject[] Energys;
    private int energy_amount;
    public float under_20;
    public float is_100;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        energy_amount = num_Energy();
        Debug.Log(energy_amount);
        create_energy();
        speed = 3f;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Move()
    {
        
    }
    bool check_is_100()
    {
        Debug.Log(0);
        Debug.Log(Random.value);
        if (Random.value < is_100)
        {
            return true;
        }
        return false;
    }

    bool check_is_under_20()
    {
        Debug.Log(0);
        Debug.Log(Random.value);
        if (Random.value < under_20)
        {
            return true;
        }
        return false;
    }

    int num_Energy()
    {
        if (check_is_under_20())
        {
            return Random.Range(1, 21);
        }
        if (check_is_100())
        {
            return 100;
        }

        return Random.Range(21, 100);
            
        
    }

    void create_energy()
    {
        if (energy_amount == 100)
        {
            Energys = new GameObject[1];
            Energys[0] = (GameObject)Instantiate(Energy_100, this.transform.position, Quaternion.identity);
            Energys[0].transform.parent = this.transform;

            return;
        }
        int num50 = energy_amount / 50;
        int num10 = energy_amount % 50 / 10;
        int num5 = energy_amount % 10 / 5;
        int num1 = energy_amount % 10 % 5;
        int all = num50 + num10 + num5 + num1;
        Energys = new GameObject[all];
        int NumArray = 0;
        if (num50 != 0)
        {
            for(int i = 0; i < num50; i++)
            {
                Energys[NumArray] = (GameObject)Instantiate(Energy_50, this.transform.position, Quaternion.identity);
                Energys[NumArray].transform.parent = this.transform;
                NumArray += 1;
            }
            
        }
        if (num10 != 0)
        {
            for (int i = 0; i < num10; i++)
            {
                Energys[NumArray] =  (GameObject)Instantiate(Energy_10, this.transform.position, Quaternion.identity);
                Energys[NumArray].transform.parent = this.transform;
                NumArray += 1;
            }

        }
        if (num5 != 0)
        {
            for (int i = 0; i < num5; i++)
            {
                Energys[NumArray] =  (GameObject)Instantiate(Energy_5, this.transform.position, Quaternion.identity);
                Energys[NumArray].transform.parent = this.transform;
                NumArray += 1;
            }

        }
        if (num1 != 0)
        {
            for (int i = 0; i < num1; i++)
            {
                Energys[NumArray] =  (GameObject)Instantiate(Energy_1, this.transform.position, Quaternion.identity);
                Energys[NumArray].transform.parent = this.transform;
                NumArray += 1;
            }

        }
    }



    
    
}
