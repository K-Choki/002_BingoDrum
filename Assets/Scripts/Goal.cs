using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject Button_Win, Button_Lose;
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Win"))
        {
            Button_Win.SetActive(true);
            Debug.Log("당첨!");
        }
        else if (other.CompareTag("Lose")) ;
        {
            Button_Lose.SetActive(true);
            Debug.Log("꽝!");
        }
    }
}
