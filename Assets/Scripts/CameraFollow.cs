using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform targetTransform;

    private Vector3 offset; // 相机与主角之间的偏移

	// Use this for initialization
	void Start () {
        // 计算出偏移量
        offset = transform.position - targetTransform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = targetTransform.position + offset;
	}
}
