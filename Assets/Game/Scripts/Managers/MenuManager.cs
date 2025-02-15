using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void LoadLevelScene()
    {
        SceneManager.LoadScene(1);
    }
}
