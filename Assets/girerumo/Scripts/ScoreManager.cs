using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int score = 0;
    public int Energy_point = 100;
    public int Enemy_point = 100;
    

    public int get_score()
    {
        return score;
    }

    private void add_score(int x)
    {
        score += (x);
    }

    public void energy_destroyed(int x)
    {
        add_score(Energy_point * x);
    }

    public void enemy_destroyed(int x)
    {
        add_score(Enemy_point * x);
    }
}
