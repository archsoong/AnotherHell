using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float moveSpeed = 5f;
    bool isRightDirection;
	// Use this for initialization
	void Start () {
        isRightDirection = true;//玩家預設面向右	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            if (!isRightDirection)
            {
                transform.localScale = new Vector3(-1*transform.localScale.x, 1, 1);
                isRightDirection = true;
            }
            transform.position += new Vector3(moveSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (isRightDirection)
            {
                transform.localScale = new Vector3(-1 * transform.localScale.x, 1, 1);
                isRightDirection = false;
            }
            transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0, 0);
        }
    }
}
