using UnityEngine;

public class PlayerLife : MonoBehaviour, IDieable
{
    public void Die()
    {
        Debug.Log("Die");
        EventBroker.CallOnPlayerDie();
    }
}
