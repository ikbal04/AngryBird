using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    [SerializeField] string _nextLevelName;
    private Monster[] _monsters;

   

    private void OnEnable()
    {
        _monsters = FindObjectsOfType<Monster>();
    }
    private void Update()
    {
        if (MonstersAreAllDead())
        {
            GoToNextLevel();
        }
    }

  

    private bool MonstersAreAllDead()
    {
        foreach (var monster in _monsters)
        {
            if (monster.gameObject.activeSelf)
            {
                return false;
            }
        }return true;
    }
    private void GoToNextLevel()
    {
        SceneManager.LoadScene(_nextLevelName);
    }

}
