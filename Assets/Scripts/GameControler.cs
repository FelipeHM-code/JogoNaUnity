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
        updateScoreText(); 
    }

    public void updateScoreText()
    {
        scoreText.text = TotalScore.ToString();
    }
}
