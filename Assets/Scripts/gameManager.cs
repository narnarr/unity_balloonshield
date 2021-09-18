using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject box;
    public GameObject gameOverText;
    
    public Text timeText;
    float time = 0.0f;

    public Animator anim;
    public GameObject balloon;

    public static gameManager I;

    void Awake()
    {
        I = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeBox", 0.0f, 0.5f);
    }

    void makeBox()
    {
        Instantiate(box);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timeText.text = time.ToString("N2");
    }

    public void gameOver()
    {
        anim.SetBool("isDead", true);
        gameOverText.SetActive(true);
        Invoke("dead", 0.5f);
    }

    void dead()
    {
        Time.timeScale = 0.0f;
        Destroy(balloon);
    }
}
