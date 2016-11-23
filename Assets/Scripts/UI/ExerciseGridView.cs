using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ExerciseGridView : MonoBehaviour 
{
	public List<ExerciseGridDisplay> exerciseGrid;

	void Start () 
	{
		float delayPerEntry = 0.15f;
		float delay = 0.0f;
		for (int i = 0; i < exerciseGrid.Count; ++i) 
		{
			exerciseGrid[i].Initialize(i, delay);

			delay += delayPerEntry;
		}
	}
}
