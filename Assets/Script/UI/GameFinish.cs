using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFinish : MonoBehaviour
{
    private ScoreManager _scoreManager;
    private PlayerManager _playerManager;
    public TMP_Text matchOutcome;
    private void Awake()
    {
        GameLoader.CallOnComplete(Initialize);
    }

    private void Initialize()
    {
        _scoreManager = ServiceLocator.Get<ScoreManager>();
        _playerManager = ServiceLocator.Get<PlayerManager>();
        DisplayScore();
    }

    private void DisplayScore()
    {
        if (_scoreManager.TeamOneScore > _scoreManager.TeamTwoScore)
        {
            matchOutcome.text = "Team One Wins! Score: " + _scoreManager.TeamOneScore + "-" + _scoreManager.TeamTwoScore;
        }
        else if (_scoreManager.TeamOneScore < _scoreManager.TeamTwoScore)
        {
            matchOutcome.text = "Team Two Wins! Score: " + _scoreManager.TeamTwoScore + "-" + _scoreManager.TeamOneScore;
        }
        else
        {
            matchOutcome.text = "Tie! Score: " + _scoreManager.TeamOneScore + "-" + _scoreManager.TeamTwoScore;
        }
    }

    public void BackToMainMenu()
    {
        _scoreManager.IsMatchOver = false;
        _scoreManager.ResetScore();
        ResetPlayers();
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    private void ResetPlayers()
    {
        _playerManager.mPlayersList[0] = _playerManager.FireHero;
        _playerManager.mPlayersList[1] = _playerManager.WaterHero;
        _playerManager.mPlayersList[2] = _playerManager.AirHero;
        _playerManager.mPlayersList[3] = _playerManager.EarthHero;

        _playerManager.TeamOne.Clear();
        _playerManager.TeamTwo.Clear();
    }
}
