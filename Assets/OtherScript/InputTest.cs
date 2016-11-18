using UnityEngine;
using System.Collections;

public class InputTest : MonoBehaviour {
	// Update is called once per frame
	void Update () {
        if (Input.touchCount != 0)
        {
            Vector3 touchPOS=Input.GetTouch(0).position;
        }
	}
}
