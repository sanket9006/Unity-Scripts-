using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuitApplication : MonoBehaviour {

	public void quit() {
		Debug.log("Application ended");
		Application.Quit();
	}
}
