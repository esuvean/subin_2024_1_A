using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExPlayer : MonoBehaviour
{
    public int HP = 100;
    public Text TextUI = null;

    // Update is called once per frame
    void Update()
    {
        TextUI.text = HP.ToString();

        if(Input.GetMouseButtonDown(0))
        {
            HP -= 10;
            if(HP <= 0)
            {
                TextUI.text = HP.ToString();
                Destroy(gameObject);
            }
        }
        
    }
}
