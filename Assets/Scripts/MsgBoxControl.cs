using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MsgBoxControl : MonoBehaviour
{
    private Text text;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //������ʾ�ı�
    public void ShowText(string name, string content)
    {
        this.transform.GetChild(0).GetComponent<Text>().text = name;
        this.transform.GetChild(1).GetComponent<Text>().text = content;
    }
}
