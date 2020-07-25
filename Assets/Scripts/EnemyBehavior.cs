using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
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
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

    }
}

