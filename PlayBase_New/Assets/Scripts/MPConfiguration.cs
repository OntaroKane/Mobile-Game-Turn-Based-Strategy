using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MPConfiguration : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        Image PanelColor = GameObject.Find("MenuPanel").GetComponent<Image>();
        PanelColor.color = Color.blue;
        //StartCoroutine(Example());
    }

    // Update is called once per frame
    void Update()
    {

    }
}

//IEnumerator Example()
//{
//    Image PanelColor = GameObject.Find("MenuPanel").GetComponent<Image>();
//    yield return new WaitForSecondsRealtime(5);
//    PanelColor.color = Color.red;
//    yield return new WaitForSecondsRealtime(5);
//    PanelColor.color = Color.cyan;
//}
//StartCoroutine(Example());