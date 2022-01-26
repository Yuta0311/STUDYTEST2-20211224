using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objecthit : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;//プレイヤーがその物体に当たるとその物体が赤色に変わる
            gameObject.tag = "Hit";//プレイヤーがその物体に当たるとその物体のタグがHITタグに変わる

        }
        
    }

}
