using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Vector3 newPosition;

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            col.transform.position = newPosition;
        }
    }
}
