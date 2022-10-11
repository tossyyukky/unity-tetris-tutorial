using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 変数の作成
    // スポナー
    // 生成されたブロック格納

    Spawner spawner;
    Block activeBlock;

    // スポナーオブジェクトをスポナー変数に格納するコードの記述
    void Start()
    {
        spawner = GameObject.FindObjectOfType<Spawner>();
        
        // スポナークラスからブロック生成関数を呼んで変数に格納する
        if (!activeBlock)
        {
            activeBlock = spawner.SpawnBlock();
        }
    }


}
