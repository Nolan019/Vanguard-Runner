using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float bulletSpeed;
    public float InstanTimer = 2f;
    public GameObject myPrefabObject;
    public float delay;
    // Start is called before the first frame update
    void Update()
    {
        CreatePrefab();
    }

    // Update is called once per frame
    void CreatePrefab()
    {
        InstanTimer -= Time.deltaTime;
        if (InstanTimer <= 0)
        {
            Vector3 position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
            GameObject copy = Instantiate(myPrefabObject, position, Quaternion.identity);
            copy.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);
            InstanTimer = 2f;
            Destroy(copy, delay);
        }
    }
    
    
}
