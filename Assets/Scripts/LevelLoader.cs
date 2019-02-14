using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{

	public static LevelLoader Instance;
	void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
		}
		else
		{
			if (Instance == this)
				return;
			else
				Debug.LogError("More than one instance of "+GetType().Name+" found");
		}
	}

	[Header("Internal Data")]
	public GameObject HiddenBoard;

	[Header("Public Data")]
	//prefab structure
	public GameObject[] KnivesPrefabs;
	public GameObject[] BoardPrefabs;
	
	[Header("Game Mechanics")]
	// no of knives per level
	public int[] KnivesInLevels;

	void Start()
	{
		LoadLevel(0);
	}

	public void LoadLevel(int LevelNum)
	{
		LevelHandler.Instance.NuOfKnives = KnivesInLevels[LevelNum];

		//need to set up level using knives and board decided by level num
		LevelHandler.Instance.SetUpLevel(KnivesPrefabs[0], BoardPrefabs[0]);
	}

}
