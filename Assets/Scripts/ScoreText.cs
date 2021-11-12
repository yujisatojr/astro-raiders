using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Text scoreText;

    private void Update()
    {
        scoreText.text = "Score: " + EnvManager.Instance.score;

    }
    // Start is called before the first frame update
    public void updateScore()
    {
        EnvManager.Instance.score += 30;
        scoreText.text = "Score: " + EnvManager.Instance.score;
    }
}
