using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManger Gamemanager;
    private void OnTriggerEnter(Collider other)
    {
        Gamemanager.CompletedLevel();
    }
}
