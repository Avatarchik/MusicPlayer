using UnityEngine;
using System.Collections;

public class DestroyTest : MonoBehaviour {
    public GameObject ball;
	// Use this for initialization
	void Start () {
        //Destroy(ball.GetComponent<Rigidbody>());
        Destroy(this.GetComponent<DestroyTest>(), 5);
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    void OnDestroy()
    {
        Debug.Log("this script has been destroy");
    }
}
