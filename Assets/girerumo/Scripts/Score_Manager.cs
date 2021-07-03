using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_Manager : MonoBehaviour
{
    private int score = 0;
    public int Energy_point = 100;
    public int Enemy_point = 100;


    public int get_score()
    {
        return score;
    }

    public void add_score(int x)
    {
        score += x;
    }

    private int energy_destroyed()
    {
        return 1;
    }

    private int enemy_destroyed();
}
