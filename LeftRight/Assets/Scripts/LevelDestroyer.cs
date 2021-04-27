using UnityEngine;

public class LevelDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("LevelEndPoint"))
        {
            Debug.Log("Destroy");
            Destroy(collision.transform.parent.gameObject);
        }
    }
}
