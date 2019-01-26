using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointsystem : MonoBehaviour
{
    public static int leekpoints;
    public static int flourpoints;
    public static int cornpoints; 
    
    // Start is called before the first frame update
    void Start()
    {
        leekpoints = 0;
        flourpoints = 2;
        cornpoints = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if ((leekpoints == 2) && (flourpoints == 2) && (cornpoints == 4)){
            Debug.Log("Finish");
        }
    }
}
