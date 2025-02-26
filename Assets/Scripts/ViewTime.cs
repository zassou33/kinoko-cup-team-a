using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Diagnostics;

public class ViewTime : MonoBehaviour
{
    public float countTime = 0.0f;
    public Text viewTime;
    GameObject JudgeObject;
    JudgeGame JudgeGame;

    /**
    <summary>
    設定の説明ー＞
    JudgeObjectやJudgeGameはflagを呼び出すための変数

    適用対象ー＞
    Timeオブジェクト
    
    動作の説明ー＞
    Start関数でJudgeObjectクラスを呼び出しflag変数を取得
    flagが０の時はタイマーを動かし、flagが1の時は止める
    <summary>
    */

    void Start()
    {
        JudgeObject = GameObject.Find("JudgeObject");
        JudgeGame = JudgeObject.GetComponent<JudgeGame>();
    }

    void Update(){
        if(JudgeGame.flag == 0)
        {
            countTime = Time.time;
        }
        else
        {
            countTime = countTime;
        }
        
        viewTime.text = countTime.ToString("f0") + "秒";
    }
}