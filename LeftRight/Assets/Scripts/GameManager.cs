using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject startingPoint;
    [SerializeField] private List<GameObject> levels;

    private GameObject previousLevel, currentLevel, nextLevel;

    #region Subscribing and Unsubscribing to events
    private void OnEnable()
    {
        EventBroker.OnCreaterLevelEndPoint += CreateRandomLevel;
    }

    private void OnDestroy()
    {
        EventBroker.OnCreaterLevelEndPoint -= CreateRandomLevel;
    }
    #endregion

    private void Start()
    {
        CreateStartingPoint();

        currentLevel = startingPoint;
    }

    public void RestartGame()
    {
        States.ResetStates();
        EventBroker.CallOnGameRestart();
    }

    private void CreateStartingPoint()
    {
        Instantiate(startingPoint, transform.position, Quaternion.identity);

        Vector3 firstLevelPosition = new Vector3(0, startingPoint.transform.position.y + 40, 0);

        GameObject firstLevel = Instantiate(GetRandomLevel(), firstLevelPosition, Quaternion.identity);

        currentLevel = firstLevel;
    }

    private void CreateRandomLevel(GameObject collidedLevel)
    {
        currentLevel = collidedLevel;

        Vector3 newLevelPosition = new Vector3(0, currentLevel.transform.position.y + 40, 0);

        nextLevel = Instantiate(GetRandomLevel(), newLevelPosition, Quaternion.identity);
    }

    private GameObject GetRandomLevel()
    {
        int randomIndex = Random.Range(0, levels.Count);

        GameObject randomLevel = levels[randomIndex];

        return randomLevel;
    }
}