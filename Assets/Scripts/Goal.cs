using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public GameObject Button_Win, Button_Lose,Case,Case2,ReStartButton;
    private void OnTriggerExit(Collider other)
    {
        Case.SetActive(false);
        Case2.SetActive(true);
        ReStartButton.SetActive(true);
        if (other.CompareTag("Win"))
        {
            Button_Win.SetActive(true);
            Debug.Log("당첨!");
        }
        else if (other.CompareTag("Lose"))
        {
            Button_Lose.SetActive(true);
            Debug.Log("꽝!");
        }
    }
    public void RestartCurrentScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
