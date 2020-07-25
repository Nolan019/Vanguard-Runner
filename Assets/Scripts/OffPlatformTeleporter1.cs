using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffPlatformTeleporter1 : MonoBehaviour
{
    public Vector3 newPosition;
    public MainCharacter script; 

    void Start()
    {
        script = FindObjectOfType<MainCharacter>();
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            col.transform.position = newPosition;
            script.liveCount--;

         if (script.liveCount <= 0)
            {
                script.canvas.SetActive(true);
                script.camera.transform.parent = null;
                Destroy(col.gameObject);
                
            }
        }
    }
}
