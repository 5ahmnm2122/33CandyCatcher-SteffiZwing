using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
	public TextMeshProUGUI pointsText;
    public MyScore myScore;
    public static int localScore;
    public Text endPointsText;

    private void Start()
    {
        localScore = 0;
        pointsText.text = localScore.ToString();
    }

    private void Update()
    {
        pointsText.text = localScore.ToString();
    }
    
    public void SaveScore()
    {
        myScore.score = localScore;
        endPointsText.text = "Your Score: " + myScore.score.ToString();
    }


}
