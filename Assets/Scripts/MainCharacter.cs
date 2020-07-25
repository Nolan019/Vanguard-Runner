using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;


public class MainCharacter : MonoBehaviour
{
    public float speed;
    public float jumpHeight;
    public int liveCount = 3;
    public GameObject canvas;
    public GameObject camera;
    public bool playerOnGround;
  

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(horizontal, 0, vertical);
        GetComponent<Animator>().SetBool("Movements", Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Vertical") > 0);

        

        if (Input.GetKeyDown(KeyCode.Space) && playerOnGround)
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpHeight, 0), ForceMode.Impulse);
            GetComponent<Animator>().SetBool("Jump", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("Jump", false);
        }


    }



    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject);
        if (collision.gameObject.tag == "Ground")
            playerOnGround = true;

        if (collision.gameObject.tag == "EnemyBullet")
        {
            liveCount = liveCount - 1;
        }
        if (collision.gameObject.tag == "EnemyBullet" && liveCount <= 0)
        {
            canvas.SetActive(true);
            camera.transform.parent = null;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }


    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
            playerOnGround = false;
    }

}