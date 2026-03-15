using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public void Load()
    {
        SceneManager.LoadScene("Game");
    }
}
