using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseUI : MonoBehaviour
{
    private PlayerManager _PlayerManager;
    private ScoreManager _ScoreManager;
    public Canvas mCanvas;

    private void Awake()
    {
        GameLoader.CallOnComplete(Initialize);
    }

    private void Initialize()
    {
        _PlayerManager = ServiceLocator.Get<PlayerManager>();
        _ScoreManager = ServiceLocator.Get<ScoreManager>();
    }

    private void Start()
    {
        if (_PlayerManager.mPlayersList[0].gameObject != null)
        {
            _PlayerManager.mPlayersList[0].GetComponent<HeroActions>().onPausePeformed += PauseGame;
        }
        if (_PlayerManager.mPlayersList[1].gameObject != null)
        {
            _PlayerManager.mPlayersList[1].GetComponent<HeroActions>().onPausePeformed += PauseGame;
        }
        if (_PlayerManager.mPlayersList[2].gameObject != null)
        {
            _PlayerManager.mPlayersList[2].GetComponent<HeroActions>().onPausePeformed += PauseGame;
        }
        if (_PlayerManager.mPlayersList[3].gameObject != null)
        {
            _PlayerManager.mPlayersList[3].GetComponent<HeroActions>().onPausePeformed += PauseGame;
        }
    }
    

    public void PauseGame()
    {
        mCanvas.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        mCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void BackToMainMenu()
    {
        ResetPlayers();
        _ScoreManager.ResetScore();
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    private void ResetPlayers()
    {
        _PlayerManager.mPlayersList[0] = _PlayerManager.FireHero;
        _PlayerManager.mPlayersList[1] = _PlayerManager.WaterHero;
        _PlayerManager.mPlayersList[2] = _PlayerManager.AirHero;
        _PlayerManager.mPlayersList[3] = _PlayerManager.EarthHero;

        _PlayerManager.TeamOne.Clear();
        _PlayerManager.TeamTwo.Clear();

        _ScoreManager.PracticeMode = false;
        Cursor.visible = true;
    }
}
