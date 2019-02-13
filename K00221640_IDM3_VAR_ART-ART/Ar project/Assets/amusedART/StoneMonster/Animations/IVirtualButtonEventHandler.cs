using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbScript : MonoBehaviour, IVirtualButtonEventHandler {
    private GameObject vbButtonObject;
	// Use this for initialization
	void Start () {
        vbButtonObject = GameObject.Find("Button");
        vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}
	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb){

    }

    void IVirtualButtonEventHandler.OnButtonPressed(VirtualButtonBehaviour vb)
    {
        throw new System.NotImplementedException();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        throw new System.NotImplementedException();
    }
}
