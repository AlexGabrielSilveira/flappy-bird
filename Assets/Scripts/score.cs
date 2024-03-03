using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {

        bool isAplayer = other.gameObject.CompareTag("flappy");

        if(isAplayer) {
            var score = GameManager.Instance.score ++;
            Debug.Log("Pontos:" + score);
        }
    }
}
