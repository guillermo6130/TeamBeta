using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Energy : MonoBehaviour
{
    private int Energy_now;
    private void Start()
    {
        Energy_now = 0;
    }

    public void addEnergy(int x)
    {
        Energy_now += x;
        Debug.Log(Energy_now);
    }

    public void setEnergy(int x)
    {
        Energy_now = x;
    }

    public int getEnergy()
    {
        return Energy_now;
    }
}
