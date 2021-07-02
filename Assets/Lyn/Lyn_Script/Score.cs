using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    // スコアを表示する
    public Text scoreText;

    // スコア
    private int score;


    // PlayerPrefsで保存するためのキー
    private string ScoreKey = "Score";

    void Start()
    {
        Initialize();
    }

    void Update()
    {
        // スコアを表示する
        scoreText.text = score.ToString();
    }

    // ゲーム開始前の状態に戻す
    private void Initialize()
    {
        // スコアを0に戻す
        score = 000000000;

    }

    // ポイントの追加
    public void AddPoint(int point)
    {
        score = score + point;
    }
}