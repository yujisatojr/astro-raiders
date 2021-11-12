using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionManager : MonoBehaviour
{
    public GameObject explosion;
    //private AudioSource projectileAudio;
    //public AudioClip explosionSound;
    //public GameObject sound;
    // Start is called before the first frame update
    void Start()
    {
        //projectileAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Enemy")) {
            Debug.Log("Collision!");
            playExplosion();
            Destroy(gameObject);
            Destroy(other.gameObject);
            //SceneManager.LoadScene(2);
        }
    }

    private void playExplosion() {
        GameObject e = Instantiate(explosion) as GameObject;
        e.transform.position = transform.position;
        Destroy(e, 2.0f);
        EnvManager.Instance.score += 30;

        //projectileAudio.PlayOneShot(explosionSound, 2.0f);

        //exp.transform.position = transform.position;
        //exp.Play();
    }
}
