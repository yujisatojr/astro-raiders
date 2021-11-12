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

    private void Awake()
    {
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
    }

    private void Update()
    {

    }

    public void setHealth(int damage)
    {
        health += damage;
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
