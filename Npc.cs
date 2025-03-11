using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    int health = 5;
    int level = 1;
    float speed = 1.2f;
    void Start()
    {
        health += level;
        print("Lives:" + health);
    }

    // Update is called once per frame
    void Update()
    {
        print("time"+ Time.deltaTime);
        Vector3 newPosition = transform.position;
        newPosition.z += speed*Time.deltaTime;
        transform.position = newPosition;
    }
}
