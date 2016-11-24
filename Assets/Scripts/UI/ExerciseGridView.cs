using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ExerciseGridView : MonoBehaviour 
{
	public WorkoutData workoutData;
	public UILabel workoutName;
	public List<ExerciseGridDisplay> exerciseGrid;

	void Start () 
	{
		if(workoutData == null) 
		{
			Debug.LogError("Missing workout data");
			return;
		}

		workoutName.text = workoutData.workoutName;

		Debug.Assert(workoutData.exercises.Count == exerciseGrid.Count, "Mismatching number of exercises for workout and display");

		float delayPerEntry = 0.15f;
		float delay = 0.0f;
		for (int i = 0; i < exerciseGrid.Count; ++i) 
		{
			exerciseGrid[i].Initialize(i, workoutData.exercises[i], delay);

			delay += delayPerEntry;
		}
	}
}
