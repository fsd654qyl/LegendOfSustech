﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Main : MonoBehaviour
{
    [SerializeField] public SpriteRenderer backGround;

    [SerializeField] public controller c;

    public battle_data battleData;
    // Start is called before the first frame update

    //在sense加载最开始调用
    private void Awake()
    {
        //获取双方对战数据，生成battleData
        //该部分数据直接在这里生成要用于测试
        //否则应该是从database中读取或者通过网络接收
        List<int[]> myList = new List<int[]>();
        List<int[]> opList = new List<int[]>();

        myList.Add(new int[7]{2,0,0,0,0,0,0});
        myList.Add(new int[7]{2,1,0,0,0,0,0});
        myList.Add(new int[7]{2,2,0,0,0,0,0});
        myList.Add(new int[7]{1,0,1,0,0,0,0});
        myList.Add(new int[7]{3,2,1,0,0,0,0});
        myList.Add(new int[7]{3,0,2,0,0,0,0});
        myList.Add(new int[7]{3,1,2,0,0,0,0});
        
        opList.Add(new int[7]{2,0,0,0,0,0,0});
        opList.Add(new int[7]{2,1,0,0,0,0,0});
        opList.Add(new int[7]{1,0,1,0,0,0,0});
        opList.Add(new int[7]{3,1,1,0,0,0,0});
        opList.Add(new int[7]{3,2,1,0,0,0,0});
        opList.Add(new int[7]{1,0,2,0,0,0,0});
        opList.Add(new int[7]{1,2,2,0,0,0,0});

        battle_data bd = new battle_data(myList, opList);

        //家在数据到controller中
        controller.Instance.Initial(bd);

        //开始战斗流程
        controller.Instance.Start_Animation();

    }
    void Start()
    {
        
    }


    void Update()
    {

    }
}
