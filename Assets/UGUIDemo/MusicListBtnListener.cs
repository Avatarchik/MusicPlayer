using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MusicListBtnListener : MonoBehaviour {
    public AudioClip[] ac;
    public GameObject List;
    public GameObject musicBT;
    public Button bEdit;
    //public Button[] bMusic;
    private ArrayList alb=new ArrayList();

    private bool isEdit=false;
	void Start () {
        //bMusic=new Button[ac.Length];

        for (int i = 0; i < ac.Length; i++)//生成按钮
        {
            GameObject bt = Instantiate(musicBT);
            bt.GetComponent<RectTransform>().SetParent(List.GetComponent<RectTransform>());
            bt.GetComponent<RectTransform>().localScale = Vector3.one;  //调整大小
            bt.GetComponent<RectTransform>().localPosition = Vector3.zero;  //调整位置
            string[] musicInfomation = ac[i].name.Split('-');
            bt.transform.FindChild("Count").GetComponent<Text>().text = ""+(i+1);//编号
            bt.transform.FindChild("MusicInformation").GetComponent<Text>().text =  //歌手 名称
                string.Format("<size=12>{0}</size>" + "\n<size=15>{1}</size>", musicInfomation[0], musicInfomation[1]);
            bt.GetComponent<Button>().onClick.AddListener(          //
                delegate()
                {
                    this.onListElementBtnClick(bt);
                }
                );
            Button bdelete = bt.transform.FindChild("DeleteBT").GetComponent<Button>();
            bdelete.onClick.AddListener(
                    delegate()
                    {
                        this.OnDeleteBthClick(bt);                    
                    }
                );
            //bMusic[i] = bt.GetComponent<Button>();

            //alb.Add(bMusic[i]);
        }
        List.GetComponent<RectTransform>().sizeDelta = new Vector2(400, ac.Length * 50 + (ac.Length - 1) * 5);
        bEdit.onClick.AddListener(OnEditBtnListener);
        for (int i = 0; i < List.transform.childCount; i++)//添加到动态数组
        {
            alb.Add(List.transform.GetChild(i));
        }
        //EventTriggerListener.Get(bEdit.gameObject).onClick = (onEditBtnListener);
    }
    public void onListElementBtnClick(GameObject bt)
    {
        Debug.Log("this is bt"+bt.name);
    }
    void OnEditBtnListener()
    {
        isEdit = !isEdit;
        foreach (Transform go in alb)
        {
                
                go.transform.FindChild("DeleteBT").gameObject.SetActive(isEdit);
            //Debug.Log(bm.name);
        }
    }
    void OnDeleteBthClick( GameObject bt)
    {
        //Debug.Log(alb.IndexOf(bt.transform));
        alb.Remove(bt.transform);
        //该控件长度  该编号 
        Destroy(bt);
        UpdateMusicArrayListButtonText();
        //Debug.Log(alb.Count);
    }
    void UpdateMusicArrayListButtonText()
    { 
        foreach(Transform go in alb)//gengxin
        {
            go.transform.FindChild("Count").GetComponent<Text>().text = "" + (alb.IndexOf(go.transform) + 1);//编号
            Debug.Log((alb.IndexOf(go.transform) + 1));
        }
        List.GetComponent<RectTransform>().sizeDelta = new Vector2(400, (alb.Count+1) * 50);
    }
}
