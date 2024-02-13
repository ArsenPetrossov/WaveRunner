using System.Collections;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] 
    private GameObject _gameOverPanel;
    [SerializeField] 
    private GameObject _gameOverEffectPanel;
    [SerializeField] 
    private GameObject _touchToMoveTextObj;
    [SerializeField] 
    private GameObject _startFadeInObj;


    private void Awake()
    {
        Application.targetFrameRate = 60;
        // Создадим объект класса GameTags для хранения тегов. (Данный класс реализует паттерн синглтон)
        new GameTags();
        Time.timeScale = 1.0f;

        StartCoroutine(FadeIn());
    }

    private void Update()
    {
        if (_touchToMoveTextObj.activeSelf == false) return;
        if (Input.GetMouseButton(0))
        {
            _touchToMoveTextObj.SetActive(false);
        }
    }

    private IEnumerator FadeIn()
    {
        _startFadeInObj.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        _startFadeInObj.SetActive(false);
    }

    public void GameOver()
    {
        StartCoroutine(GameOverCoroutine());
    }

    private IEnumerator GameOverCoroutine()
    {
        _gameOverEffectPanel.SetActive(true);
        Time.timeScale = 0.1f;
        yield return new WaitForSecondsRealtime(0.5f);
        _gameOverPanel.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}