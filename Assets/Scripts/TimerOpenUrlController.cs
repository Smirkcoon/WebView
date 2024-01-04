using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerOpenUrlController : MonoBehaviour
{
    [SerializeField] private int secondsWait = 4;
    [SerializeField] private SampleWebView _sampleWebView;
    [SerializeField] private TMP_Text timerText;
    private int secondsCurrent;
    IEnumerator Start()
    {
        timerText.text = secondsWait.ToString();
        while (secondsCurrent < secondsWait)
        {
            yield return new WaitForSeconds(1);
            secondsCurrent++;
            if (secondsCurrent >= secondsWait)
                _sampleWebView.OpenUrl();
            timerText.text = (secondsWait - secondsCurrent).ToString();
            //Debug.Log("TimerOpenUrl secondsCurrent " + secondsCurrent);
        }
    }
    
}
