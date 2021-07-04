using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Energy : MonoBehaviour
{
    private int Energy_now;
    [SerializeField] private Text energy_text;

    private void Start()
    {
        Energy_now = 0;
    }

    public void addEnergy(int x)
    {
        Energy_now += x;
        /*Debug.Log(Energy_now);*/
        setEnergyText();

    }

    public void setEnergy(int x)
    {
        Energy_now = x;
        setEnergyText();
    }

    public int getEnergy()
    {
        return Energy_now;
    }

    private void setEnergyText()
    {
        energy_text.text = Energy_now.ToString();
    }
}
