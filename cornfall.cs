using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class cornfall : MonoBehaviour
{
    public GameObject display;
    private Rigidbody2D thisRb;
    private Vector2 OriginalPosition;
    AudioSource audioData;

    public int cornpoints;



    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();

        Debug.Log(OriginalPosition);
        Debug.Log("Start");
        gameObject.transform.Translate(0.0f, 0.0f, 0.0f);
        Debug.Log(OriginalPosition);

        cornpoints = pointsystem.cornpoints;



    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Enter");
        if (collision.gameObject.tag == "Floor")
        {
            Debug.Log("collided");


            gameObject.transform.position = new Vector2(Random.Range(-10, 10), 10);
        }

        if (collision.gameObject.tag == "Player")
        {
            audioData.Play(0);
            pointsystem.cornpoints = pointsystem.cornpoints + 1;
            Debug.Log(pointsystem.cornpoints);
            gameObject.transform.position = new Vector2(Random.Range(-10, 10), 10);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

