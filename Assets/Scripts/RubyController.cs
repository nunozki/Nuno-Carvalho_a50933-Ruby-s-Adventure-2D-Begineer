using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //QualitySettings.vSyncCount = 0;
        //Application.targetFrameRate = 10;
    }
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        //Debug.Log(horizontal);
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        //position.x = position.x + 0.1f
        //position.x = position.x + 0.3f
        //position.x = position.x + 0.01f
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;
        transform.position = position;
    }
}
