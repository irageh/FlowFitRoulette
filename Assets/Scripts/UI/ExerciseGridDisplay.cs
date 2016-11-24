using UnityEngine;
using System.Collections;
using DG.Tweening;

public class ExerciseGridDisplay : MonoBehaviour 
{
	public UILabel nameLabel;
	public GameObject exerciseDetailViewPrefab;

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

	private GameObject _detailView;

	void Start () 
	{
	
	}

	public void Initialize(int index, ExerciseData exerciseData, float introAnimDelay)
	{
		_index = index;
		_exerciseData = exerciseData;

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
		if (_detailView != null) 
		{
			return;
		}

		if (_displayState != DisplayState.Revealed) 
		{
			return;
		}

		Debug.Assert (exerciseDetailViewPrefab != null, "Missing detail view prefab");

		_detailView = ScreenSpawner.Instance.SpawnScreen(exerciseDetailViewPrefab);
		ExerciseDetailView detailView = _detailView.GetComponent<ExerciseDetailView>();
		if(detailView != null) 
		{
			detailView.Initialize(_exerciseData, gameObject.transform.position);
		}
	}
}
