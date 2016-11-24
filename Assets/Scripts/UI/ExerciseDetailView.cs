using UnityEngine;
using System.Collections;

public class ExerciseDetailView : ScreenBase {

	public UILabel exerciseName;
	public UILabel tipsLabel;

	private ExerciseData _exerciseData;
	
	public void Initialize(ExerciseData exerciseData, Vector3 spawnPosition)
	{
		_exerciseData = exerciseData;

		exerciseName.text = exerciseData.exerciseName;
		tipsLabel.text = exerciseData.tips;

		BeginIntroAnim(spawnPosition);
	}
}
