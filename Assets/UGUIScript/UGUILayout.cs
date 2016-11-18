using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class UGUILayout : MonoBehaviour {
    public GameObject UIMain;
    public GameObject items;
	// Use this for initialization
	void Start () {
        for (int i = 0; i < 10; i++)
        { 
            GameObject item = (GameObject)Instantiate(items);
            item.transform.parent = UIMain.transform;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
