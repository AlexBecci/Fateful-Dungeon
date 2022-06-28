using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoadManager : MonoBehaviour
{
 [SerializeField] private Slider loadBar;
 [SerializeField] private GameObject loadPanel;

    public void SceneLoad(int sceneIndex)
    {
        print("Aca llego Antes del Enumerator");
        loadPanel.SetActive(true);
        StartCoroutine(LoadAsync(sceneIndex));
    }

    IEnumerator LoadAsync(int sceneIndex)
    {
        print("Aca llego");
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneIndex);

        while (!asyncOperation.isDone)
        {
            print(asyncOperation.progress);
            loadBar.value = asyncOperation.progress / 0.9f;
            yield return null;
        }
    }
 
}
