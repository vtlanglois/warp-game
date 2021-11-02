using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    Text timerText;
    float time;
    void Start()
    {
        timerText = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = "Time: " + (int) time;
        time += Time.deltaTime;
    }
}
