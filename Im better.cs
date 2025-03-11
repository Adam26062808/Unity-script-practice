using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imbetter : MonoBehaviour
{
    int health = 3;
    int level = 2;

    void Start()
    {
       health = health + level;
       print("Player health:" + health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
