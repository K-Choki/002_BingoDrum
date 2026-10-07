using UnityEngine;

public class Goal : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Win"))
        {
            Debug.Log("당첨!");
        }
        else if (other.CompareTag("Lose")) ;
        {
            Debug.Log("꽝!");
        }
    }
}
