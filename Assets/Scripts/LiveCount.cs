using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LiveCount : MonoBehaviour
{
    public MainCharacter script;
   
    // Start is called before the first frame update
    void Start()
    {
        script = FindObjectOfType<MainCharacter>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = script.liveCount.ToString();
    }
}
