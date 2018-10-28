using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    public GameObject[] chests;
    public Sprite closedChest;
    public Sprite openedChest;
    public GameObject[] triggers;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void openChest(int index)
    {
        bool isIndexCorrect = true;//判斷這個開啟寶箱的索引是否為正確的順序
        for(int i = 0; i < index; i++)
        {
            if (chests[i].GetComponent<SpriteRenderer>().sprite == closedChest)
            {
                isIndexCorrect = false;
            }
        }
        //如果跑完for，isIndexCorrect都是true代表前面的寶箱都已經被打開，這個寶箱才可被打開
        //反之，如果前面有寶箱沒有被打開，代表這個索引是錯誤的順序 所有寶箱要關閉
        if (isIndexCorrect)
        {
            chests[index].GetComponent<SpriteRenderer>().sprite = openedChest;
        }
        else
        {
            for(int i = 0; i < index; i++)
            {
                chests[i].GetComponent<SpriteRenderer>().sprite = closedChest;
            }
        }
    }
}
