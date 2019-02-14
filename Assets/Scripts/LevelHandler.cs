using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelHandler : MonoBehaviour
{
	public static LevelHandler Instance;
	void Awake()
	{
		//setting Instance
		if (Instance == null)
		{
			Instance = this;
		}
		else
		{
			if (Instance == this)
				return;
			else
				Debug.LogError("More than one instance of " + GetType().Name + " found");
		}
	}
	[Header("Game SetUp")]
	public GameObject GameCanvas;
	public int NuOfKnives;

	public OnCircleCollided circleCollidedRef;

	//[Header("Current game data")]
	private int _KnivesRemaining;
	private GameObject _knife, _board, _CurKnife, _curBoard;

	
	/// <summary>
	/// Sets up each level to begin playing
	/// </summary>
	/// <param name="_knifePrefab">the knife prefab to use in this level</param>
	/// <param name="_knifeBoard">the board prefab to use in this level</param>
	public void SetUpLevel(GameObject _knifePrefab, GameObject _knifeBoard)
	{
		_KnivesRemaining = NuOfKnives;
		_knife = _knifePrefab;
		_board = _knifeBoard;

		//create a new Knife
		_CurKnife = Instantiate(_knife, LevelLoader.Instance.HiddenBoard.transform);
		_CurKnife.SetActive(true);
		_CurKnife.GetComponent<RectTransform>().localPosition = _knifePrefab.GetComponent<RectTransform>().localPosition;

		//Create a new Board
		_curBoard = Instantiate(_board, GameCanvas.GetComponent<RectTransform>());
		_curBoard.SetActive(true);
		_curBoard.GetComponent<RectTransform>().localPosition = _knifeBoard.GetComponent<RectTransform>().localPosition;

		//make the New Board rotate over the hidden board
		circleCollidedRef.CoverObject = _curBoard.GetComponent<RectTransform>();
	}


}
