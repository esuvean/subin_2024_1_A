using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] circleObject;
    public Transform getTransform;
    public float timeCheck;
    public bool isGen;

    public void GenObject()
    {
        isGen = false;
        timeCheck = 1.0f;
    }


    // Start is called before the first frame update
    void Start()
    {
        GenObject();
    }

    // Update is called once per frame
    void Update()
    {
        if(isGen == false)
        {
            timeCheck -= Time.deltaTime;
            if(timeCheck <= 0.0f)
            {
                int RandomNumber = Random.Range(0, 3);
                GameObject Temp = Instantiate(circleObject[RandomNumber]);
                Temp.transform.position = getTransform.position;
                isGen = true;
            }
        }
    }

    public void MergeObject(int index, Vector3 position)
    {
        GameObject Temp = Instantiate(circleObject[index]);
        Temp.transform.position = position;
        Temp.GetComponent<CircleObject>().Used();
    }
}
