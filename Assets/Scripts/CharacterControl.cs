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
    //������������
    public void LoadFace(string num)
    {
        //������������
        Sprite sp = Resources.Load<Sprite>("paojieface_" + num);//Ҫ����Resources�ļ�����,���Ʋ��ܴ�
        transform.GetChild(0).GetComponent<Image>().sprite = sp;
    }

    //�����첿��ǩ
    public void LoadMouth(string num)
    {
        //�����첿����
        Sprite sp = Resources.Load<Sprite>("paojiemouth_" + num);
        transform.GetChild(1).GetComponent<Image>().sprite = sp;
    }
}
