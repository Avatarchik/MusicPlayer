using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MusicBtnListener : MonoBehaviour {
    public Button bplay;
    public Button bnext;
    public Button blist;
    public Button bsound;
    public Button bbackMenu;
    public GameObject MusicPlayer;
    public GameObject MusicList;
    private bool setSound = false;
    private bool showList = false;
         
	// Use this for initialization
	void Start () {
        blist.onClick.AddListener(OnListBtnClick);
        bplay.onClick.AddListener(OnPlayBtnClick);
        bsound.onClick.AddListener(OnSoundBtnClick);
        bbackMenu.onClick.AddListener(OnListBtnClick);
	}
	
	// Update is called once per frame
	void Update () {

	}
    void OnListBtnClick()
    {
        showList = !showList;
        MusicList.SetActive(showList);
    }
    void OnPlayBtnClick()
    {
        Debug.Log("play");
        
    }

    void OnSoundBtnClick()
    {
        setSound = !setSound;
        bsound.transform.GetChild(0).gameObject.SetActive(setSound);//开启/关闭 背景遮罩
        bsound.transform.GetChild(1).gameObject.SetActive(setSound);//开启/关闭 音量滑块
        //Debug.Log("Sound bt click");
    }

}
