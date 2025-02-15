using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    #region SINGLETON
    public static UiManager Instance;

    private void Awake()
    {
        Instance = this;
    }
    #endregion

    public GameObject nextLevelPanel;
    public GameObject failedLevelPanel;

    //[SerializeField] private GameObject _nextLevelPanel; 
    //[SerializeField] private GameObject _failedLevelPanel; 
    //public void OpenNextLevelPanel()
    //{
    //    _nextLevelPanel.SetActive(true);

    //}

    //public void OpenFailedLevelPanel()
    //{
    //    _failedLevelPanel.SetActive(true);
    //}

    public void OpenPanel(GameObject openedPanel)
    {
        nextLevelPanel.SetActive(false);
        failedLevelPanel.SetActive(false);

        openedPanel.SetActive(true);
    }

    public void NextLevelButton()
    {
        SceneManager.LoadScene(2);
    } 
    
    public void RetryLevelButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
