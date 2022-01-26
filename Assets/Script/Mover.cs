using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    //移動スピードを変える（SerializeFieldは入力欄を作るイメージ）（floatは変数を作る）
    //[SerializeField] float xValue = 0;
    //[SerializeField] float yValue = 0.01f; プレイヤーが上下することはいらないので消す
    //[SerializeField] float zValue = 0;

    [SerializeField] float movespeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the game.");
        Debug.Log("Move your player with MASD or arrow key.");
        Debug.Log("Don't hit the walls.");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
        transform.Translate(xValue, 0, zValue); //transformは移動をさせている（上の変数を代入してスピードを変えている）
    }

}
