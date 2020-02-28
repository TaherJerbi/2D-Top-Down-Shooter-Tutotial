using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chronometer : MonoBehaviour
{
    float timer;
    public Text timerText;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        timerText.text = Mathf.FloorToInt(timer).ToString();
    }

}
