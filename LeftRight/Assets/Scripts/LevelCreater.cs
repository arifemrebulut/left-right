using UnityEngine;

public class LevelCreater : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("LevelEndPoint"))
        {
            EventBroker.CallOnCreaterLevelEndPoint(collision.transform.parent.gameObject);
        }
    }
}
