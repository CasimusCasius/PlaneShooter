using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    

    // Update is called once per frame
    void Update()
    {
        timerText.text = string.Format("Time left: {0}",GameTimer.Instance.GetTimeRemined());
    }
}
