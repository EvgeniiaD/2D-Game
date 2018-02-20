using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Hide();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void Show()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Hide()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }
}
