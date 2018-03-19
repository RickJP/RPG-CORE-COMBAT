using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeObserver : MonoBehaviour {

    CameraRaycaster cameraRaycaster;

	void Start () {
        cameraRaycaster = GetComponent<CameraRaycaster>();
        cameraRaycaster.onLayerChange += MyHandlingFunction;
	}
	

	void MyHandlingFunction (Layer newLayer)
    {

	}
}
