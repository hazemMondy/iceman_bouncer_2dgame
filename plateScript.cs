using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateScript : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float boundY = 5.5f;
    public bool moveRight, moveLeft, breakable, death, normal;

    private Animator anime;
    private void Awake()
    {
        if (breakable)
        {
            anime = GetComponent<Animator>();
        }
    }

    void Update()
    {
        move();
    }
    private void move()
    {
        Vector2 temp = transform.position;
        temp.y += Time.deltaTime * moveSpeed;
        transform.position = temp;
        if (temp.y >= boundY)
        {
            gameObject.SetActive(false);
        }
    }
    void breakableDeactivate()
    {
        Invoke("deactivateGameObject",0.3f);
    }
    void deactivateGameObject()
    {
        gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (death)
            {
                collision.transform.position = new Vector2(1000f, 1000f);
                //SoundManager.instance.GameOverSound();
                //GameManager.instance.RestartGame();
            }
        }
    }
}
