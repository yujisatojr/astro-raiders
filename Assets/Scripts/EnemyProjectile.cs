using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyProjectile : MonoBehaviour
{
    [SerializeField] GameObject ball;
    private float k;
    public Quaternion rotation = Quaternion.identity;

    private int bossHealth = 50;
    private bool bossDead = false;
    public GameObject explosion;
    private AudioSource playerAudio;
    public AudioClip crashSound;
 
    void Start()
    {
        //MoveDown();
        playerAudio = GetComponent<AudioSource>();
        StartCoroutine("BallSet");
        k = 0;
    }

    void Update()
    {
        MoveDown();
    }

    void MoveDown()
    {
        Vector3 newPos = new Vector3(0, 13, 0);
        transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime * 1);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Missile")) {
            //Debug.Log("Collision with Boss!");
            Destroy(other.gameObject);
            bossHealth--;
            playerAudio.PlayOneShot(crashSound, 1.0f);
            Debug.Log("Boss HP: " + bossHealth);
            if (bossHealth <= 0 && bossDead == false)
            {
                bossDead = true;

                GameObject e = Instantiate(explosion) as GameObject;
                e.transform.position = transform.position;
                Destroy(e, 2.0f);
                EnvManager.Instance.score += 500;

                Destroy(gameObject);
                Destroy(other.gameObject);
                SceneManager.LoadScene(2);
            }
            //SceneManager.LoadScene(2);
        }
    }
 
    IEnumerator BallSet()
    {
        for (int i=0; i<50; i++)
        {
            rotation.eulerAngles = new Vector3(k, 90, 90);
            yield return new WaitForSeconds(0.3f);
            Instantiate(ball,transform.position,rotation);
            k += 30;
        }
    }

    void DelayChange()
    {
        Invoke("DelayMethod", 3.5f);
    }

    void DelayMethod()
    {
        Debug.Log("Delay call");
    }
}
