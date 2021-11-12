using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastBossControl : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    private float k;

    private int bossHealth = 30;
    private bool bossDead = false;
    public GameObject explosion;
 
    void Start()
    {
        //MoveDown();
        StartCoroutine("BallSet", 5.0f);
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
            Debug.Log("Boss HP: " + bossHealth);
            if (bossHealth <= 0 && bossDead == false)
            {
                bossDead = true;

                GameObject e = Instantiate(explosion) as GameObject;
                e.transform.position = transform.position;
                Destroy(e, 2.0f);
                EnvManager.Instance.score += 1000;

                Destroy(gameObject);
                Destroy(other.gameObject);
                SceneManager.LoadScene(3);
            }
            //SceneManager.LoadScene(2);
        }
    }
 
    IEnumerator BallSet()
    {
        for (int i=0; i<50; i++)
        {
            yield return new WaitForSeconds(0.5f);
            Instantiate(projectile,transform.position,projectile.transform.rotation);
            //k += 30;
        }
    }
}
