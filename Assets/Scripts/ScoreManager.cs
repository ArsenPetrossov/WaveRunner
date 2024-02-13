using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private const string BEST_SCORE_KEY = "BestScore";
    public static ScoreManager Instance;

    [SerializeField] 
    private Text _currentScoreText;
    [SerializeField] 
    private Text _bestScoreText;

    private int _score;

    private void Awake()
    {
        Instance = this;

        _currentScoreText.text = "0";
        _bestScoreText.text = PlayerPrefs.GetInt(BEST_SCORE_KEY, 0).ToString();
    }

    public void AddScore()
    {
        _score++;
        _currentScoreText.text = _score.ToString();

        if (_score > PlayerPrefs.GetInt(BEST_SCORE_KEY, 0))
        {
            PlayerPrefs.SetInt(BEST_SCORE_KEY, _score);
            _bestScoreText.text = PlayerPrefs.GetInt(BEST_SCORE_KEY, 0).ToString();
        }
    }
}