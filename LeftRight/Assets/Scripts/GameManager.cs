using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject startingPoint;
    [SerializeField] private List<GameObject> levels;

    private GameObject currentLevel, nextLevel;
    private List<GameObject> instatiatedLevels;

    #region Subscribing and Unsubscribing to events
    private void OnEnable()
    {
        EventBroker.OnCreaterLevelEndPoint += CreateRandomLevel;
        EventBroker.OnGameRestart += DeleteLevels;
        EventBroker.OnGameRestart += CreateStartingPoint;
    }

    private void OnDestroy()
    {
        EventBroker.OnCreaterLevelEndPoint -= CreateRandomLevel;
        EventBroker.OnGameRestart -= DeleteLevels;
        EventBroker.OnGameRestart -= CreateStartingPoint;
    }
    #endregion

    private void Start()
    {
        instatiatedLevels = new List<GameObject>();

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
        GameObject startingLevel = Instantiate(startingPoint, transform.position, Quaternion.identity);

        instatiatedLevels.Add(startingLevel);

        Vector3 firstLevelPosition = new Vector3(0, startingPoint.transform.position.y + 40, 0);

        GameObject firstLevel = Instantiate(GetRandomLevel(), firstLevelPosition, Quaternion.identity);

        instatiatedLevels.Add(firstLevel);

        currentLevel = firstLevel;
    }

    private void CreateRandomLevel(GameObject collidedLevel)
    {
        currentLevel = collidedLevel;

        Vector3 newLevelPosition = new Vector3(0, currentLevel.transform.position.y + 40, 0);

        nextLevel = Instantiate(GetRandomLevel(), newLevelPosition, Quaternion.identity);

        instatiatedLevels.Add(nextLevel);
    }

    private GameObject GetRandomLevel()
    {
        int randomIndex = Random.Range(0, levels.Count);

        GameObject randomLevel = levels[randomIndex];

        return randomLevel;
    }

    private void DeleteLevels()
    {
        foreach (var level in instatiatedLevels)
        {
            Destroy(level.gameObject);
        }
    }
}