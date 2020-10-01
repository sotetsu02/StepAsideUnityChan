using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{
    //カメラのオブジェクト
    private GameObject MainCamera;
    //カメラとアイテムの距離
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        //カメラのオブジェクトを取得
        this.MainCamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        //アイテムとカメラとの距離を測る
        this.difference = this.transform.position.z - MainCamera.transform.position.z;
        //もしアイテムとの距離がマイナスであればアイテムを破棄
        if (difference <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
