using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnvManager : MonoBehaviour
{
    public static EnvManager Instance;
    private int maxHealth = 300;
    public int health;
    public int score;
    //public TextMeshProUGUI scoreText;


    private void Awake()
    {
        //scoreText.text = "Score: " + score;
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
 

    private void Start()
    {
        health = maxHealth;
        //score = 0;
        //scoreText.text = "Score: " + score;

        //scoreText = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        //scoreText = TMPro.TextMeshPro.Find("ScoreText");
        //scoreText = gameObject.Find("ScoreText").GetComponent<TMPro.TextMeshProUGUI>();

        //scoreText = gameObject.GetComponent<TMPro.TextMeshPro>().text;
        //scoreText.text = "Score: " + score;

    }

    public void setHealth(int damage)
    {
        health += damage;
        //if (health <= 0) { SceneManager.LoadScene(3); }
        //else if (health > 100) { health = 100; }
    }

    public int getHealth()
    {
        return health;
    }

    public int getScore()
    {
        return score;
    }

}
