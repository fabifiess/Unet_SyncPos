﻿// This script is designed to establish references for instantiated prefabs because you cannot 
// assign references to prefabs directly. 
// Attach this script to an empty gameobject (maybe called "Manager") which is always available in scene

using UnityEngine;

public class ReferenceManager : MonoBehaviour {

	public GameObject camera;
	// reference to this script, must be static
	private static ReferenceManager refManagerScript;
	void Awake(){
		// reference to this script
		refManagerScript = this;
	}
	
	public static ReferenceManager Instance {
		get {
			return refManagerScript; // returns a reference to this script
		}
	}
}

// in order to reference other gameobjects in prefabs (no linking possible), reference these gameobjects
// in this script which is always available in scene. When the prefab needing the reference
// becomes instantiated, the reference to the reference needed. In the Start function. Like this:
// GameObject camera;
// void Start(){
// 		camera = ReferenceManager.Instance.camera;
// }