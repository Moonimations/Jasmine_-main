using UnityEngine;
using UnityEngine.SceneManagement;
 
public class SceneChange : MonoBehaviour
{

    public GameObject audio;

    void OnEnable()
    {

        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        audio.SetActive(false);
        SceneManager.LoadScene("Level 1", LoadSceneMode.Single);
        
    }
}