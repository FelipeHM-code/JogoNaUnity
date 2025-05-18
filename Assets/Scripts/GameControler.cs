using UnityEngine;

public class GameControler : MonoBehaviour
{
    public int TotalScore;
    public static GameControler instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instance = this;
    }


}
