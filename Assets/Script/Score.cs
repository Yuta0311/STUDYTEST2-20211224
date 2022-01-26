using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int hits = 0;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Hit")//HITタグ以外の物に当たるとカウントされる
        {
            hits++;
            Debug.Log("ぶつかりました" + hits);
        }
    }

}
