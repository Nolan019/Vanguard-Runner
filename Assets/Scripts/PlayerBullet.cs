using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float bulletSpeed;
    public GameObject myPrefabObject;
    public GameObject camera;
    public float delay;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
            GameObject copy = Instantiate(myPrefabObject, position, Quaternion.identity);
          
            copy.GetComponent<Rigidbody>().AddForce(camera.transform.forward * bulletSpeed, ForceMode.Impulse);
            Destroy(copy, delay);
        }

    }
}
