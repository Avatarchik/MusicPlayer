using UnityEngine;
using System.Collections;
public class Skin : MonoBehaviour {
    public GUISkin[] gskin;
    public int skin_Index=0;
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            skin_Index++;
            if (skin_Index >= gskin.Length)
            {
                skin_Index = 0;
            }
        }
	}
    void OnGUI()
    {
        GUI.skin = gskin[skin_Index];
        if (GUI.Button(new Rect(0, 0, Screen.width / 10, Screen.height / 10),"a button"))
        {
            Debug.Log("Button has been pressed");
        }
        GUI.Label(new Rect(0,Screen.height*2/10,Screen.width/10,Screen.height/10),"a lable");
    }
}
