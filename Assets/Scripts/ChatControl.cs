using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Say
{
    public string name;
    public string content;
    public string face;
    public string mouth;
}

public class ChatControl : MonoBehaviour
{
    public MsgBoxControl MsgBox;
    public CharacterControl charC;
    Say[] says;
    //��ǰ�ĶԻ�����
    int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        //�����Ի� ������ļ���ʽ
        Say say1 = new Say() {name = "XR", content = "Hi~", face = "03", mouth = "02" };
        Say say2 = new Say() {name = "XR", content = "666", face = "02", mouth = "03" };
        Say say3 = new Say() {name = "XR", content = "777", face = "01", mouth = "04" };

        says = new Say[] {say1, say2 , say3};
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(index < says.Length)
            {
                Say say = says[index++];
                //��ʾ�Ի�
                MsgBox.ShowText(say.name, say.content);
                charC.LoadFace(say.face);
                charC.LoadMouth(say.mouth);
            }
        }
    }


}
