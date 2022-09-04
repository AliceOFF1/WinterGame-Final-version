using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChangerSecond : MonoBehaviour
{
    private Animator anim;
    public int levelToLoad;


    public Vector3 position;
    public VectorValue playerStorage;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void FadeToLevel()
    {
        anim.SetTrigger("FadeSecond");
    }

    public void OnFadeComlete()
    {
        playerStorage.initialValue = position;
        SceneManager.LoadScene(levelToLoad);
    }
}
