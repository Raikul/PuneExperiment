using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{

    public static GameAssets instance;

    public Sprite snakeHeadSprite;




    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
