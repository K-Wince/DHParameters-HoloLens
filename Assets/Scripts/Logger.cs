using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Logger : MonoBehaviour
{
    [SerializeField] private Transform frame0;
    [SerializeField] private Transform frame1;
    [SerializeField] private Transform frame2;
    [SerializeField] private Transform frame3;
    [SerializeField] private Transform frame4;
    [SerializeField] private Transform frame5;
    [SerializeField] private Transform frame6;
    [SerializeField] private Transform canvas;
    // Start is called before the first frame update
    void Start()
    {
        /*frame0 = GameObject.Find("gnomonxyz007-0").transform;
        frame1 = GameObject.Find("gnomonxyz007-1").transform;
        frame2 = GameObject.Find("gnomonxyz007-2").transform;
        frame3 = GameObject.Find("gnomonxyz007-3").transform;
        frame4 = GameObject.Find("gnomonxyz007-4").transform;
        frame5 = GameObject.Find("gnomonxyz007-5").transform;
        frame6 = GameObject.Find("gnomonxyz007-6").transform;
        canvas = GameObject.Find("Canvas-Overlay").transform;
        Debug.Log(canvas);*/
    }

    // Update is called once per frame
    void Update()
    {
        canvas.GetChild(0).GetComponent<TextMeshPro>().SetText("Frame 0: (" + frame0.position.x.ToString("F5") + ", " + frame0.position.y.ToString("F5") + ", " + frame0.position.z.ToString("F5") + ")");
        canvas.GetChild(1).GetComponent<TextMeshPro>().SetText("Frame 1: (" + frame1.position.x.ToString("F5") + ", " + frame1.position.y.ToString("F5") + ", " + frame1.position.z.ToString("F5") + ")");
        canvas.GetChild(2).GetComponent<TextMeshPro>().SetText("Frame 2: (" + frame2.position.x.ToString("F5") + ", " + frame2.position.y.ToString("F5") + ", " + frame2.position.z.ToString("F5") + ")");
        canvas.GetChild(3).GetComponent<TextMeshPro>().SetText("Frame 3: (" + frame3.position.x.ToString("F5") + ", " + frame3.position.y.ToString("F5") + ", " + frame3.position.z.ToString("F5") + ")");
        canvas.GetChild(4).GetComponent<TextMeshPro>().SetText("Frame 4: (" + frame4.position.x.ToString("F5") + ", " + frame4.position.y.ToString("F5") + ", " + frame4.position.z.ToString("F5") + ")");
        canvas.GetChild(5).GetComponent<TextMeshPro>().SetText("Frame 5: (" + frame5.position.x.ToString("F5") + ", " + frame5.position.y.ToString("F5") + ", " + frame5.position.z.ToString("F5") + ")");
        canvas.GetChild(6).GetComponent<TextMeshPro>().SetText("Frame 6: (" + frame6.position.x.ToString("F5") + ", " + frame6.position.y.ToString("F5") + ", " + frame6.position.z.ToString("F5") + ")");
    }

    // Create a GUI to list information
    /*public void OnGUI()
    {
        GUIStyle centeredStyle = GUI.skin.GetStyle("Label");
        centeredStyle.alignment = TextAnchor.UpperLeft;
        centeredStyle.normal.textColor = Color.black;
        centeredStyle.fontSize = 20;
        GUI.Label(new Rect(10, Screen.height - Screen.height * 0.14, 400, Screen.height * 0.02), "Frame 0: " + frame0.position, centeredStyle);
        GUI.Label(new Rect(10, Screen.height - Screen.height * 0.12, 400, Screen.height * 0.02), "Frame 1: " + frame1.position, centeredStyle);
        GUI.Label(new Rect(10, Screen.height - Screen.height * 0.1, 400, Screen.height * 0.02), "Frame 2: " + frame2.position, centeredStyle);
        GUI.Label(new Rect(10, Screen.height - Screen.height * 0.08, 400, Screen.height * 0.02), "Frame 3: " + frame3.position, centeredStyle);
        GUI.Label(new Rect(10, Screen.height - Screen.height * 0.06, 400, Screen.height * 0.02), "Frame 4: " + frame4.position, centeredStyle);
        GUI.Label(new Rect(10, Screen.height - Screen.height * 0.04, 400, Screen.height * 0.02), "Frame 5: " + frame5.position, centeredStyle);
        GUI.Label(new Rect(10, Screen.height - Screen.height * 0.02, 400, Screen.height * 0.02), "Frame 6: " + frame6.position, centeredStyle);
    }*/
}
