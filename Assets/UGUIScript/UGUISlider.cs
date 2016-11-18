using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class UGUISlider : MonoBehaviour {
	public Slider sd;
	public void OnsdValueChange()
	{
		Debug.Log (sd.value);
	}
}
