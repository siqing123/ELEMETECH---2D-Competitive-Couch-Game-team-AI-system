using UnityEngine;

public class ScoreManager : MonoBehaviour
{    
    [SerializeField] private int _teamOneScore = 0;
    [SerializeField] private int _teamTwoScore = 0;
    [SerializeField] bool _isPracticeMode = false;
    [SerializeField] bool _isMatchOver = false;

    public int TeamOneScore { get => _teamOneScore; }
    public int TeamTwoScore { get => _teamTwoScore; }
    public bool IsMatchOver { get => _isMatchOver; set => _isMatchOver = value; }
    public bool PracticeMode { get { return _isPracticeMode;} set { _isPracticeMode = value; } }

    private void Awake()
    {
        ServiceLocator.Register<ScoreManager>(this);
    }

    public void AddPoints(int team, int points)
    {
        switch (team)
        {
            case 1:
                _teamOneScore++;
                break;
            case 2:
                _teamTwoScore++;
                break; 
            default:
                break;
        }
    }

    public void ResetScore()
    {
        _teamOneScore = 0;
        _teamTwoScore = 0;
        _isMatchOver = false;
    }
}
