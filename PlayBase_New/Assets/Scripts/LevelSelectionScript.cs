using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelectionScript : MonoBehaviour {

    
    //Set this in the Inspector
    public Sprite m_Sprite;
    Image m_Image;
    void Start()
    {
        //Fetch the Image from the GameObject
        m_Image = GameObject.Find("LevelImage").GetComponent<Image>();
    }

    //void Update()
    //{
    //    //Press space to change the Sprite of the Image
    //    if (Input.GetKey(KeyCode.Space))
    //    {
    //        m_Image.sprite = m_Sprite;
    //    }
    //}

    public void clicky() {
        m_Image.sprite = m_Sprite;
    }
}
