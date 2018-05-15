using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformSpecificText : MonoBehaviour {
	public string editor = "";
	public string macos = "";
	public string windows = "";
	public string linux = "";
	public string standalone = "";
	public string ios = "";
	public string android = "";
	public string webgl = "";

	void Awake () {
		var text = transform.GetComponent<Text> ();
		#if UNITY_EDITOR
			text.text = editor;
		#endif
		#if UNITY_STANDALONE_OSX
			text.text = macos;
		#endif
		#if UNITY_STANDALONE_WIN
			text.text = windows;
		#endif
		#if UNITY_STANDALONE_LINUX
			text.text = linux;
		#endif
		#if UNITY_STANDALONE
			text.text = standalone;
		#endif
		#if UNITY_IOS
			text.text = ios;
		#endif
		#if UNITY_ANDROID
			text.text = android;
		#endif
		#if UNITY_WEBGL	
			text.text = webgl;
		#endif
	}

}
