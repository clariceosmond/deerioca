using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class charactermove : MonoBehaviour
{
    public float speed;
    private float t = 0.0f;
    private bool moving = false;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.Translate(0.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector2(speed*Input.GetAxis("Horizontal"), 0.0f));
    }
}

