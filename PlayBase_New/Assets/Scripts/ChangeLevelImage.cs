using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeLevelImage : MonoBehaviour {

    public void LoadImage(string number)
    {
        var doiD = Resources.Load<Sprite>("LevelImages/" + number + ".png");
        Image LevelImage = GameObject.Find("LevelImage").GetComponent<Image>();
        LevelImage.sprite = doiD;

    }
}

//public String LoadButtonText(string buttonName)
//{
//    String ButtonText = GameObject.Find(buttonName).name;
//    return ButtonText;
//}


////Load a text file (Assets/Resources/Text/textFile01.txt)
//var textFile = Resources.Load<TextAsset>("Text/textFile01");

////Load text from a JSON file (Assets/Resources/Text/jsonFile01.json)
//var jsonTextFile = Resources.Load<TextAsset>("Text/jsonFile01");
////Then use JsonUtility.FromJson<T>() to deserialize jsonTextFile into an object

////Load a Texture (Assets/Resources/Textures/texture01.png)
//var texture = Resources.Load<Texture2D>("Textures/texture01");

////Load a Sprite (Assets/Resources/Sprites/sprite01.png)
//var sprite = Resources.Load<Sprite>("Sprites/sprite01");

////Load an AudioClip (Assets/Resources/Audio/audioClip01.mp3)
//var audioClip = Resources.Load<AudioClip>("Audio/audioClip01");