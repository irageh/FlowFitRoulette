using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenuAttribute]
public class ExerciseData : ScriptableObject 
{
	public string exerciseId;
	public string exerciseName;

	public string videoPath;
	public string tips;

	public List<string> regressionIds;
}
