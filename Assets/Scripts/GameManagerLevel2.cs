using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerLevel2 : MonoBehaviour
{
    bool firstScore = true;
    bool firstHealth = true;
    public GameObject bossPrefabs1;
    public GameObject bossPrefabs2;
    public GameObject bossPrefabs3;
    public int bossHealth = 30;
    public GameObject levelText;
    public float timeValue = 120;
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ShowLevel", 1);
        StartCoroutine("SpawnBoss", 1);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (EnvManager.Instance.score > 900 && firstScore != false)
        {
            firstScore = false;
            Vector3 spawnPos = new Vector3(0, 21, 0);
            Instantiate(bossPrefabs1, spawnPos, bossPrefabs1.transform.rotation);

            Vector3 spawnPos2 = new Vector3(9.5f, 17f, 0);
            Instantiate(bossPrefabs2, spawnPos2, bossPrefabs2.transform.rotation);

            Vector3 spawnPos3 = new Vector3(-9.5f, 17f, 0);
            Instantiate(bossPrefabs2, spawnPos3, bossPrefabs3.transform.rotation);
        }
        */

        if (EnvManager.Instance.health <= 0 && firstHealth != false)
        {
            firstHealth = false;
            SceneManager.LoadScene(4);
        }

        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }

        ShowTime(timeValue);

        if (timeValue < 0)
        {
            SceneManager.LoadScene(4);
        }
    }

    void ShowTime(float time)
    {
        if (time < 0)
        {
            time = 0;
        }

        float min = Mathf.FloorToInt(time / 60);
        float sec = Mathf.FloorToInt(time % 60);

        timerText.text = string.Format("{0:00}:{1:00}", min, sec);
    }

    IEnumerator ShowLevel()
    {
        levelText.SetActive(true);
        yield return new WaitForSeconds(3);
        levelText.SetActive(false);
    }

    IEnumerator SpawnBoss()
    {
        yield return new WaitForSeconds(20);
        Vector3 spawnPos = new Vector3(0, 21, 0);
        Instantiate(bossPrefabs1, spawnPos, bossPrefabs1.transform.rotation);

        Vector3 spawnPos2 = new Vector3(9.5f, 17f, 0);
        Instantiate(bossPrefabs2, spawnPos2, bossPrefabs2.transform.rotation);

        Vector3 spawnPos3 = new Vector3(-9.5f, 17f, 0);
        Instantiate(bossPrefabs2, spawnPos3, bossPrefabs3.transform.rotation);
    }
}
