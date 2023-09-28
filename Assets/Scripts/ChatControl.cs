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
    //当前的对话索引
    int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        //创建对话 最好用文件形式
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
                //显示对话
                MsgBox.ShowText(say.name, say.content);
                charC.LoadFace(say.face);
                charC.LoadMouth(say.mouth);
            }
        }
    }


}
