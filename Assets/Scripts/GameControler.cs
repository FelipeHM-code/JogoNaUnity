using UnityEngine;
using UnityEngine.UI;

public class GameControler : MonoBehaviour
{
    public int TotalScore;
    public Text scoreText;
    public static GameControler instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instance = this;
       instance = this;

     if (scoreText != null)
    {
        updateScoreText();
    }
     else
    {
        Debug.LogError("scoreText não foi atribuído no Inspector!");
    }
    }

    public void updateScoreText()
    {
        scoreText.text = TotalScore.ToString();
    }
}
