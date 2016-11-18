using UnityEngine;
using System.Collections;

public class TouchTest : MonoBehaviour {
    public GameObject ball; 
    private float lastDis=0; 
    private float cameraDis = -20;
    public float ScaleDump = 0.1f;
    void Update() {
        if (Input.touchCount ==1)//触控
        {
            Touch t = Input.GetTouch(0);//获取触控
            if (t.phase == TouchPhase.Moved)
            {
                //ball.transform.Rotate(Vector3.right, t.deltaPosition.y,Space.World);//竖直旋转 绕X轴
                //ball.transform.Rotate(Vector3.up, -1*t.deltaPosition.x, Space.World);//竖直旋转 绕X轴
                ball.transform.Rotate(Vector3.right, Input.GetAxis("Mouse Y"), Space.World);//竖直旋转 绕X轴
                ball.transform.Rotate(Vector3.up, -1 * Input.GetAxis("Mouse X"), Space.World);//竖直旋转 绕X轴
            }
        }
        else if (Input.touchCount > 1)
        {
            Touch t1 = Input.GetTouch(0);//获取触控
            Touch t2 = Input.GetTouch(1);//获取触控
            if (t2.phase == TouchPhase.Began)
            {
                lastDis = Vector2.Distance(t1.position, t2.position);
            }
            if (t1.phase == TouchPhase.Moved && t2.phase == TouchPhase.Moved)
            {
                float dis = Vector2.Distance(t1.position, t2.position);
                if (Mathf.Abs(dis - lastDis)>1)
                    cameraDis += (dis - lastDis)*ScaleDump;
                cameraDis=Mathf.Clamp(cameraDis, -40, -5);
                lastDis = dis;//备份本次触摸结果
            }

        }
    }
    void LateUpdate()
    {
        this.transform.position = new Vector3(0,0,cameraDis);
    }
    void OnGUI()
    {
        string s = string.Format("Input.touchCount={0}\ncameraDIS=\n{1}",
            Input.touchCount,cameraDis);
        GUI.TextArea(new Rect(0, 0, Screen.width / 10, Screen.height), s);
        if (GUI.Button(new Rect(Screen.width * 9 / 10, 0, Screen.width / 10, Screen.height / 10),"quit"))
        { 
            Debug.Log("quit");
            Application.Quit();
        }
    }
}
