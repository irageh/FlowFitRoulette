using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScreenSpawner : MonoBehaviour {

	public static ScreenSpawner Instance = null;

	List<GameObject> _screens = new List<GameObject>();

	void Awake () 
	{
		Instance = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public GameObject SpawnScreen(string prefabPath, bool resetTransform = true)
	{
		if(string.IsNullOrEmpty(prefabPath))
		{
			return null;
		}

		return SpawnScreen(Resources.Load(prefabPath) as GameObject, resetTransform);
	}

	public GameObject SpawnScreen(GameObject screenPrefab, bool resetTransform = true)
	{
		if(screenPrefab != null)
		{
			GameObject screen = GameObject.Instantiate(screenPrefab);
			screen.transform.SetParent(gameObject.transform, false);

			if(resetTransform)
			{
				screen.transform.localRotation = Quaternion.identity;
				screen.transform.localScale = Vector3.one;	
			}

			_screens.Add(screen);

			return screen;
		}

		return null;
	}
}
