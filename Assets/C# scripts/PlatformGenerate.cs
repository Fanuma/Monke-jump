﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerate : MonoBehaviour
{
    public GameObject platformPrefab;       // переменная для префаба

    void Start()
    {
        Vector3 SpawnerPosition = new Vector3();    // нам нужен новый вектор

        for (int i = 0; i < 1000; i++)                // цикл For, который выполняется 10 раз
        {
            SpawnerPosition.x = Random.Range(-2.3f, 2.3f);  // позиция по оси х
            SpawnerPosition.y += Random.Range(3f, 5f);      // позиция по оси у 

            Instantiate(platformPrefab, SpawnerPosition, Quaternion.identity);  // создание префабов
        }
    }

    
}
