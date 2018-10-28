using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour {
    public GameObject Core;
    public int chestIndex;//打開的寶箱索引(0~3)
    bool isPlayerOn;//player是否站在此機關上
	// Use this for initialization
	void Start () {
        isPlayerOn = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (isPlayerOn && Input.GetKeyUp(KeyCode.Space))//玩家在這個機關且按了space觸發
        {
            Core.GetComponent<Manager>().openChest(chestIndex);
        }
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        isPlayerOn = true;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        isPlayerOn = false;
    }
}
