using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour {

    private GameObject tScore;
    public int tValue = 0;
    private Text tText;

    private GameObject cScore;
    public int cValue = 0;
    private Text cText;

    // Use this for initialization
    void Start () {
        tValue = 0;
        tScore = GameObject.Find("Score/tScore");
        tText = tScore.GetComponent<Text>();

        cValue = 0;
        tScore = GameObject.Find("Score/cScore");
        cText = tScore.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        tText.text = "Terrorists killed: " + tValue;
        cText.text = "Civilians killed: " + cValue;
    }
}
