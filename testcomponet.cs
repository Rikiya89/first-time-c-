using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestComponent : MonoBehaviour
{
    // マテリアルの配列
    public Material[] materialArr;

    // Start is called before the first frame update
    void Start()
    {
        // オブジェクトの位置を取得
        Vector3 pos = transform.position;
        print("ポジション" + pos);

        // マテリアルを変更
        GetComponent<Renderer>().material = materialArr[0];
    }

    // Update is called once per frame
    void Update()
    {
        // オブジェクトを回転させる
        transform.Rotate(0f, 100f * Time.deltaTime, 0f);
    }
}
