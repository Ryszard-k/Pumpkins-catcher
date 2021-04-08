﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPumpkins : MonoBehaviour
{
    public int pumpkinValue = 1;
	
	private void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			ScoreManager.instance.ChangeScore(pumpkinValue);
		}
	}
}
