using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehavior : MonoBehaviour
{
    public int bossLiveCount = 10;
    public GameObject canvas;
    public GameObject camera;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
    void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject);
        if (collision.gameObject.tag == "Bullet")
        {
            bossLiveCount--;
        }
        if (bossLiveCount <= 0)
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            canvas.SetActive(true);
            camera.transform.parent = null;
        }
    }
}
