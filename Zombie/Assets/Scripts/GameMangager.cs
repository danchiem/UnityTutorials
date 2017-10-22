﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMangager : MonoBehaviour {

    public static GameMangager instance = null;
    public BoardManager boardScript;
    private int level = 3;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if( instance != null)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
        boardScript = GetComponent<BoardManager>();
        InitGame();
    }

    void InitGame()
    {
        boardScript.SetupScene(level);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
