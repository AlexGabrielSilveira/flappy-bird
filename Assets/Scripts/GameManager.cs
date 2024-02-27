using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}
    public List<GameObject> prefabs;
    public float obstacleInterval = 1;
    public float obstacleSpeed = 10;
    public float xOffset = 0;
    public Vector2 yOffset = new Vector2(0,0);
    // Start is called before the first frame update
    void Awake()
    {
        if(Instance != null && Instance != this) {
            Destroy(this);
        }else {
            Instance = this;
        }
    }
    
}
