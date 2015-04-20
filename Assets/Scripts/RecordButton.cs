using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RecordButton : MonoBehaviour {

    public Interpreter interp;
    private bool isRecording;
    private Text text;

    void Start()
    {
        text = GetComponentInChildren<Text>();
    }

    public void Click()
    {
        if (!isRecording)
        {
            interp.StartRecording();
            isRecording = true;
            text.text = "Stop\nRecording";
        }
        else
        {
            interp.StopRecording();
            isRecording = false;
            text.text = "Record\nCommand";
        }
    }
}
