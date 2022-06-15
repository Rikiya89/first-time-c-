using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testgameobject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //オブジェクの名前を取得
        print("オブジェクの名前は" + gameObject.name);

        //タグの名前を取得
        print("タグの名前は" + gameObject.tag);

        //オブジェクトを不活性化する
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
