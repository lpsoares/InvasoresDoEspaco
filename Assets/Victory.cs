using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Victory : MonoBehaviour
{

    public GameObject aliens;
    public GameObject player;
    
    void Update()
    {
        if( player == null)
            gameObject.GetComponent<Text>().text = "Vitória dos Aliens";
        else if(aliens.transform.childCount == 0)
        {
            gameObject.GetComponent<Text>().text = "Vitória do Jogador";
        }
    }
}
