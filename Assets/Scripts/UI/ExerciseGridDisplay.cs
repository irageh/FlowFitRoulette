using UnityEngine;
using System.Collections;
using DG.Tweening;

public class ExerciseGridDisplay : MonoBehaviour 
{
	public UILabel nameLabel;

	private int _index;
	private ExerciseData _exerciseData;

	public enum DisplayState
	{
		Hidden,
		Revealing,
		Revealed,
		Active
	}
	private DisplayState _displayState = DisplayState.Hidden;

	void Start () 
	{
	
	}

	public void Initialize(int index, ExerciseData exerciseData, float introAnimDelay)
	{
		_index = index;

		if(nameLabel != null) 
		{
			nameLabel.text = exerciseData.exerciseName;
		}

		_displayState = DisplayState.Hidden;
		gameObject.transform.DORotate(new Vector3(720.0f, 0.0f, 0.0f), 2.25f).SetRelative(true).SetEase(Ease.OutBounce).SetDelay(introAnimDelay).OnStart(OnRevealAnimStart).OnComplete(OnRevealAnimComplete);
	}

	private void OnRevealAnimStart()
	{
		_displayState = DisplayState.Revealing;
	}

	private void OnRevealAnimComplete()
	{
		_displayState = DisplayState.Revealed;
	}

	public void RevealExercise()
	{

	}

	public void OnClick()
	{
		Debug.Log ("Clicked on exercise: " + _index + ": " + gameObject.name);
	}
}
