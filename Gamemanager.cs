using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public static int nScore;

    // Start is called before the first frame update
    void Start()
    {
        nScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Restart()
    {
        Start();
    }
}
