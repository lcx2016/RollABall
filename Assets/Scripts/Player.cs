using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public float force = 1;

    public int foodCount = 10;

    public Text ScoreText;
    public GameObject winText;

    private Rigidbody rgd;
    private int score = 0;

	// Use this for initialization
	void Start () {
        rgd = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        rgd.AddForce(new Vector3(h,0,v) * force);
	}

    // 碰撞检测   有实际的物理效果，会造成阻挡效果
    //  当脚本里同时存在 OnCollisionXXX 和 OnTriggerXXX
    // 如果没有勾选  Is Trigger 那么就会触发OnCollisionXXX ，OnTriggerXXX不会被触发
    void OnCollisionEnter(Collision collision)
    {
        // collision 属于 与Player发生碰撞的游戏物体
        string tag = collision.collider.tag;
        if (tag == "Food")
        {
            //删掉与Player发生碰撞的物体
            Destroy(collision.collider.gameObject);
        }
    }

    // 触发检测   进入到某个区域内后，需要做特定的事情
    // 使用这个函数需要勾选 Collider的 Is Trigger 这个选项
    // 勾选了这个选项的话，就不会触发碰撞   player 会穿过食物
    void OnTriggerEnter(Collider collider)
    {
        string tag = collider.tag;
        if (tag == "Food")
        {
            score++;
            ScoreText.text = score.ToString();
            Destroy(collider.gameObject);
        }

        // 所有食物都被吃完了
        if (foodCount == score)
        {
            winText.SetActive(true);
        }
    }


}
