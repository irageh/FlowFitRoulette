using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenuAttribute]
public class WorkoutData : ScriptableObject 
{
	public string workoutId;
	public string workoutName;
	
	public List<ExerciseData> exercises;
}
