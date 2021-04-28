using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI currentScoreUI;
    [SerializeField] private TextMeshProUGUI lastScoreUI;

    private float currentScore;
    private float lastScore;

    private void OnEnable()
    {
        EventBroker.OnGameRestart += ResetScore;
    }

    private void OnDisable()
    {
        EventBroker.OnGameRestart -= ResetScore;
    }
    
    void Update()
    {
        if (States.currentGameState == States.GameState.OnPlay && States.currentBallMovementState != States.BallMovementState.Patrol)
        {
            CalculateScore();
        }

        WriteScoreToUI();
    }

    private void CalculateScore()
    {
        currentScore += Time.deltaTime;
      
        lastScore = currentScore;        
    }

    private void WriteScoreToUI()
    {
        currentScoreUI.text = currentScore.ToString("0");
        lastScoreUI.text = lastScore.ToString("0");
    }

    private void ResetScore()
    {       
        currentScore = 0;
    }
}
