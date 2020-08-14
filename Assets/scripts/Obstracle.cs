using UnityEngine;

public class Obstracle : MonoBehaviour
{

    public NewBehaviourScript movement;
    void OnCollisionEnter(Collision hit)
    {
        if (hit.collider.tag=="obstracle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManger>().EndGame();
        }

    }
}
