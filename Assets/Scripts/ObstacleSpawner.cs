using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleSpawner : MonoBehaviour
{
    private float cooldown = 0;

    // Update is called once per frame
    void Update()
    {   
        var gameManager = GameManager.Instance;
        if(gameManager.isGameOver()) return;
        
        cooldown -= Time.deltaTime;

        if(cooldown <= 0f) {
            cooldown = GameManager.Instance.obstacleInterval;

            int prefabIndex = Random.Range(0, gameManager.prefabs.Count);
            GameObject prefab = gameManager.prefabs[prefabIndex];
            float x = gameManager.xOffset;
            float y = Random.Range(gameManager.yOffset.x, gameManager.yOffset.y);
            Vector3 position = new Vector3(x,y,-1);

            Instantiate(prefab, position, prefab.transform.rotation);
        }
    }
}
