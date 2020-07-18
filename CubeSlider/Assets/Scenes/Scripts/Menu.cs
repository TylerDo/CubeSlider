using UnityEngine.SceneManagment;
using UnityEngine;

public class Menu : MonoBehaviour
{
    StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
