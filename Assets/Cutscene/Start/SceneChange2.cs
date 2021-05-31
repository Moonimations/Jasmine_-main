using UnityEngine;
using UnityEngine.SceneManagement;
 
public class SceneChange2 : MonoBehaviour
{
    public GameObject audio;
    void OnEnable()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        audio.SetActive(false);
        SceneManager.LoadScene("StartMenu", LoadSceneMode.Additive);
        
    }
}