using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtonControl : MonoBehaviour
{
    private int maxHealth = 100;
    public void LoadScene(int level)
    {
        SceneManager.LoadScene(0);
    }

    public void resetHealth()
    {
        EnvManager.Instance.setHealth(maxHealth);
    }
}
