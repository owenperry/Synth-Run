using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    public GameObject music;
    public void btn_change_scene(string scene_name)
    {
        string scnName = scene_name;
        Debug.Log("Clicked");
        SceneManager.LoadScene(scene_name);
    }
}
