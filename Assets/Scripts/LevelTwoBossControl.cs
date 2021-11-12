using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTwoBossControl : MonoBehaviour
{
    [SerializeField] GameObject ball;
    private float k;
    //
    public Quaternion rotation = Quaternion.identity;
    public GameObject explosion;
 
    void Start()
    {
        //MoveDown();
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
            Destroy(gameObject);
            Destroy(other.gameObject);
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
}
