using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class UGUIText : MonoBehaviour {
    public Text tt;
	void Start () {
        tt.color = Color.red;
        tt.text = "this is text";
    }
}
