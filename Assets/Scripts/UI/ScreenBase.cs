using UnityEngine;
using System.Collections;
using DG.Tweening;

public class ScreenBase : MonoBehaviour {

	private const float _animTime = 0.4f;
	private const Ease _easeType = Ease.InOutExpo;

	private Vector3 _spawnPosition;

	public void BeginIntroAnim(Vector3 spawnPosition)
	{
		_spawnPosition = spawnPosition;
		Vector3 finalPos = gameObject.transform.position;
		gameObject.transform.position = spawnPosition;
		gameObject.transform.DOMove(finalPos, _animTime).SetEase(_easeType);

		Vector3 finalScale = gameObject.transform.localScale;
		gameObject.transform.localScale = Vector3.zero;
		gameObject.transform.DOScale (finalScale, _animTime).SetEase (_easeType);
	}

	public virtual void Close()
	{
		gameObject.transform.DOMove(_spawnPosition, _animTime).SetEase(_easeType);
		gameObject.transform.DOScale(Vector3.zero, _animTime).SetEase(_easeType).OnComplete(OnCloseAnimComplete);
	}

	private void OnCloseAnimComplete()
	{
		Destroy(gameObject);
	}
}
