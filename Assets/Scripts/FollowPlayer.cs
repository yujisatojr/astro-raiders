using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private AudioSource playerAudio;
    public AudioClip crashSound;
    //private Vector3 offset = new Vector3(-15, 0, -1);
    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy")) {
            Debug.Log("Collision with Enemy");
            Destroy(other.gameObject);
            EnvManager.Instance.health -= 30;
            playerAudio.PlayOneShot(crashSound, 1.0f);
            //SceneManager.LoadScene(2);
        }

        if (other.gameObject.CompareTag("Boss")) {
            Debug.Log("Collision with Boss");
            EnvManager.Instance.health -= 30;
            playerAudio.PlayOneShot(crashSound, 1.0f);
            //SceneManager.LoadScene(2);
        }

        if (other.gameObject.CompareTag("EnemyProjectile")) {
            Debug.Log("Collision with Projectile");
            Destroy(other.gameObject);
            EnvManager.Instance.health -= 30;
            playerAudio.PlayOneShot(crashSound, 1.0f);
            //SceneManager.LoadScene(2);
        }
    }
}
