using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int score = 0;
    [SerializeField] private Text score_text;
    public int Energy_point = 100;
    public int Enemy_point = 100;
    

    public int get_score()
    {
        return score;
    }

    private void add_score(int x)
    {
        score += (x);
        setScoreText();
    }

    public void energy_destroyed(int x)
    {
        add_score(Energy_point * x);
        setScoreText();
    }

    public void enemy_destroyed(int x)
    {
        add_score(Enemy_point * x);
        setScoreText();
    }

    public void beamed(int x)
    {
        add_score(x);
        setScoreText();
    }
    private void setScoreText()
    {
        score_text.text = score.ToString();
    }
}
