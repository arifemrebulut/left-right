using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(Button))]
public class GameStateChanger : MonoBehaviour
{
    [SerializeField] private States.GameState desiredGameState;

    Button button;

    private void Start()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(ChangeGameState);
    }

    public void ChangeGameState()
    {
        States.currentGameState = desiredGameState;
    }
}
