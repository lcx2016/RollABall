using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //围绕Y轴正方向旋转   每调用一次 Rotate 旋转1度
        // 1秒可以令游戏物体旋转60度
        //transform.Rotate(Vector3.up);
        transform.Rotate(new Vector3(0, 1, 0));
    }
}
