using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float time;

    public TextMeshProUGUI timeText;
    public float maxTime = 60f;
    public string deathScene = "End";

    private ScoreManager scoreManager;
    private string scoreManagerName = "ScoreManager";

    
    void Start()
    {
        time = maxTime;
        scoreManager = GameObject.Find(scoreManagerName).GetComponent<ScoreManager>();
    }

  
    void Update()
    {
        timeText.text = time.ToString("f0");

        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else if (time <= 0)
        {
            scoreManager.SaveScore();
            SceneManager.LoadScene(deathScene);
        }

    }
}
