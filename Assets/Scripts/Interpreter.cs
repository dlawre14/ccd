using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Interpreter : MonoBehaviour {

    private string mic;
    private AudioClip currentCommand;
    private AudioSource source;

    private Dictionary<string, string> attributes;
    private Dictionary<string, Color> colors;

    private InputField inField;
    public Text output;
    public BaseMinion preview;

    void InitColors()
    {
        colors = new Dictionary<string, Color>();
        colors.Add("red", new Color(1, 0, 0, 1));
        colors.Add("blue", new Color(0, 0, 1, 1));
        colors.Add("green", new Color(0, 1, 0, 1));
        colors.Add("white", new Color(1, 1, 1, 1));
        colors.Add("black", new Color(0, 0, 0, 1));
    }

	// Use this for initialization
	void Start () {
        mic = Microphone.devices[0];
        source = GetComponent<AudioSource>();

        attributes = new Dictionary<string, string>();
        inField = GameObject.Find("Input").GetComponent<InputField>();

        InitColors();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    // This takes a string input and interprets it for modifying attributes
    public void Interpret()
    {
        string input = inField.text;
        string[] tokens = input.Split(' ');

        output.text = "Interpreted Output:\n";

        //look for key words such as color, or a color name
        foreach (string s in tokens)
        {
            #region the word color was seen
            //If the word color or colour is found, look for a color name and remove it from possible tokens
            if (s == "color" || s == "color")
            {
                for (int i = 0; i < tokens.Length; i++)
                {
                    if (colors.ContainsKey(tokens[i]))
                    {
                        if (attributes.ContainsKey("color"))
                            attributes["color"] = tokens[i];
                        else
                            attributes.Add("color", tokens[i]);
                        output.text += "Set color to " + tokens[i] + "\n";
                        tokens[i] = "";
                    }
                }
            }
            #endregion

            #region color name found without color call
            //If a color name is found, assign instantly
            for (int i = 0; i < tokens.Length; i++)
            {
                if (colors.ContainsKey(tokens[i]))
                {
                    if (attributes.ContainsKey("color"))
                        attributes["color"] = tokens[i];
                    else
                        attributes.Add("color", tokens[i]);
                    output.text += "Set color to " + tokens[i] + "\n";
                    tokens[i] = "";
                }
            }
            #endregion
        }

        WriteToMinion();
    }

    // TODO WriteToBuildFile()
    // Implements writing attributes to a build file

    public void WriteToMinion()
    {
        foreach(KeyValuePair<string,string> pair in attributes) {
            if (pair.Key == "color")
                preview.AssignColor(colors[pair.Value]);
        }
    }

    #region Microphone Stuff
    public void StartRecording()
    {
        currentCommand = Microphone.Start(mic, false, 1000, 16000);
    }

    public void StopRecording()
    {
        Microphone.End(mic);

        SavWav.Save("D:\\ccd\\Assets\\command.wav", currentCommand);
    }

    public void PlayRecording()
    {
        source.clip = currentCommand;
        source.Play();
    }

    public void CallSphynx()
    {
        /*
        Process myProc = new Process();
        myProc.StartInfo.Arguments = ;
        myProc.Start();
         */
    }
    #endregion
}
