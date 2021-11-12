using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{
    private int maxHealth = 300;
    public void LoadScene(int level)
    {
        EnvManager.Instance.health = maxHealth;
        EnvManager.Instance.score = 0;
        SceneManager.LoadScene(level);
    }

    public void resetHealth()
    {
        EnvManager.Instance.setHealth(maxHealth);
    }
}
