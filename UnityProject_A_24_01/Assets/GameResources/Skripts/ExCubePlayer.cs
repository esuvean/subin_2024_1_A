using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
public class ExCubePlayer : MonoBehaviour
{
    public Text TextUI = null;
    public int Count = 0;
    public int Power = 100;

    public int Point = 0;
    public float checkTime = 0.0f;

    public Rigidbody m_Rigidbody;

    // Update is called once per frame
    void Update()
    {

        checkTime += Time.deltaTime;
        if (checkTime >= 1.0f)
        {
            Point += 1;
            checkTime = 0.0f;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Power = Random.Range(100, 200);
            m_Rigidbody.AddForce(transform.up * Power);
        }
        TextUI.text = Point.ToString();
    }  

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Pipe")
        {
            Point = 0;
            gameObject.transform.position = Vector3.zero;
        }        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "items")
        {
            Point += 10;
            Destroy(other.gameObject);
        }
    }
}
