﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallMenuMain : MonoBehaviour {


    // Todo when main menu is called activate main menu and activate tag along script

	// Use this for initialization
	void Awake () {
        HoverScript.informationPanel = GameObject.Find("InformationPanel");
        HoverScript.informationPanel.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
