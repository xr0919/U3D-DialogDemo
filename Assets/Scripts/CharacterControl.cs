using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class CharacterControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //加载脸部表情
    public void LoadFace(string num)
    {
        //加载脸部表情
        Sprite sp = Resources.Load<Sprite>("paojieface_" + num);//要放在Resources文件夹下,名称不能错
        transform.GetChild(0).GetComponent<Image>().sprite = sp;
    }

    //加载嘴部标签
    public void LoadMouth(string num)
    {
        //加载嘴部表情
        Sprite sp = Resources.Load<Sprite>("paojiemouth_" + num);
        transform.GetChild(1).GetComponent<Image>().sprite = sp;
    }
}
