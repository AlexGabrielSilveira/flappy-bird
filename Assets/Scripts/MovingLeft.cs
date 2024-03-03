using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    void Update()
    {
        var gameManager = GameManager.Instance;
        if(gameManager.isGameOver()) return;
        
        float x = GameManager.Instance.obstacleSpeed * Time.deltaTime;
        transform.position -= new Vector3(x,0,0);
    }
}
 