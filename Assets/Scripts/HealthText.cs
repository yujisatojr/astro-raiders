using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    public TextMeshProUGUI healthText;

    private void Update()
    {
        healthText.text = "Health: " + EnvManager.Instance.health;

    }
    // Start is called before the first frame update
    public void updateScore()
    {
        EnvManager.Instance.health -= 30;
        healthText.text = "Health: " + EnvManager.Instance.health;
    }
}
