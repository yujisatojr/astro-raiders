using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    //private GameObject envManager;
    // Start is called before the first frame update
    void Start()
    {
        //playerController = GameObject.Find("EnvManager").GetComponent<GameObject>();
        GetComponent<Rigidbody>().AddForce(transform.forward * 400.0f, ForceMode.Impulse);
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        //EnvManager.Instance.updateScore();
        EnvManager.Instance.score += 30;
        Debug.Log(EnvManager.Instance.score);
    }

}
