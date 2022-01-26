using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer; // ここで定義（キャッシュのため？）
    Rigidbody rigidbody; // ここで定義（キャッシュのため？）
    [SerializeField] float TimeToWait = 5f;

    // 最初は表示されないのと重力を無効にする
    void Start()
    {
        renderer = GetComponent<MeshRenderer>(); // ここで定義（キャッシュのため？）
        rigidbody = GetComponent<Rigidbody>(); // ここで定義（キャッシュのため？）
        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // 指定の時間が経てば上記が有効になる
    void Update()
    {
        if (Time.time > TimeToWait)
        {
            //Debug.Log("指定の時間が経ちました");
            renderer.enabled = true;
            rigidbody.useGravity = true;

        }
    }
}
