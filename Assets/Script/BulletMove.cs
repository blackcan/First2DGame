﻿using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {
    public float BulletSpeed =5;
    public int Team = 0;
	void Start () {
	
	}

    void Update() {
        transform.Translate(Vector2.up * BulletSpeed * Time.deltaTime);//向上移動
        if (transform.position.y > 20 || transform.position.y < -20)
        {
            //如果物件的Y值大於20或小於20 就將物件移除
            Destroy(gameObject);

        }
    }
}
