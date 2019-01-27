using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointsystem : MonoBehaviour
{
    public int leekpoints;
    public int flourpoints;
    public int cornpoints;
    public int bombpoints;
    public bool leveluppoints;
    public bool levelfailpoints;

    public levelupsound soundd;
    public Levelfailsound sounddd;

    // Start is called before the first frame update
    void Start()
    {

        leekpoints = 0;
        flourpoints = 0;
        cornpoints = 0;
        bombpoints = 0;
        leveluppoints = false;
        levelfailpoints = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (bombpoints == 3)
        {
            levelfailpoints = true;
            Debug.Log("Failure");
            sounddd.PlayMusic();


        }
        else if ((leekpoints >= 2) && (flourpoints >= 2) && (cornpoints >= 4) && (bombpoints < 3))
        {
            leveluppoints = true;
            Debug.Log("Finish");
            soundd.PlayMusic();
        }
    }
}
