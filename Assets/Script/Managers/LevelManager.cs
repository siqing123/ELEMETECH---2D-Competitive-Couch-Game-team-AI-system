using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private ScoreManager mScoreManager;
    [SerializeField]
    private PlayerManager mPlayerManager;
    [SerializeField]
    private MatchUI MatchUI;
    private bool isMatchOver = false;
    private void Awake()
    {
        GameLoader.CallOnComplete(Initialize);
    }

    private void Initialize()
    {
        mPlayerManager = ServiceLocator.Get<PlayerManager>();
        mScoreManager = ServiceLocator.Get<ScoreManager>();
        MatchUI = FindObjectOfType<MatchUI>();
    }


    private void Update()
    {
        if (!mScoreManager.PracticeMode)
        {
            if (!mScoreManager.IsMatchOver)
            {
                if (mPlayerManager.TeamOne.Count == 1 && mPlayerManager.TeamTwo.Count == 0)
                {
                    LevelEnd(1, 1);
                }
                else if (mPlayerManager.TeamOne.Count == 2 && mPlayerManager.TeamTwo.Count == 0)
                {
                    LevelEnd(1, 1);
                }
                else if (mPlayerManager.TeamTwo.Count == 1 && mPlayerManager.TeamOne.Count == 0)
                {
                    LevelEnd(2, 1);
                }
                else if (mPlayerManager.TeamTwo.Count == 2 && mPlayerManager.TeamOne.Count == 0)
                {
                    LevelEnd(2, 1);
                }
                else if (mPlayerManager.TeamTwo.Count == 0 && mPlayerManager.TeamOne.Count == 0)
                {
                    LevelEnd(1, 0);
                }
            }
        }
    }

    private void LevelEnd(int team, int score)
    {
        mScoreManager.IsMatchOver = true;
        mScoreManager.AddPoints(team, score);
        MatchUI.MatchCanvas.gameObject.SetActive(true);
        MatchUI.displayTeamScore();
        mPlayerManager.TeamOne.Clear();
        mPlayerManager.TeamTwo.Clear();

    }
}
