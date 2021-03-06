﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyScript : MonoBehaviour
{
    Rigidbody2D dragon;
    [SerializeField]
    private float velocity = 8.0f;
    [SerializeField]
    private GameObject player = default;
    [SerializeField]
    private float maxDistance = 21f;
    [SerializeField]
    private Canvas _gameOverCanvas;
    public ParticleSystem expl;

    void Start()
    {
        dragon = GetComponent<Rigidbody2D>();
        _gameOverCanvas.gameObject.SetActive(false);

    }
    void Update()
    {
        float distance = player.transform.position.x - transform.position.x;
        float veloPlayer = player.GetComponent<Rigidbody2D>().velocity.x;

        if (veloPlayer > 0 && distance >= maxDistance)
        {
            dragon.velocity = new Vector2(veloPlayer, 0);
        }
        else
        {
            dragon.velocity = new Vector2(velocity, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != "Player")
        {
            //quebra as plataformas também. Criar efeito de dretruindo
            if (other.gameObject)
                Destroy(other.gameObject);
            //Instantiate(expl, other.gameObject.transform.position, other.gameObject.transform.rotation);

        }
        else
        {
            GamePauser.Instance.PauseGame(true);
            _gameOverCanvas.gameObject.SetActive(true);
            SoundManager.Instance.PlaySong(1, 0.7f);
            SoundManager.Instance.PlayDragonClip();//efeitos sonoros são parecidos então parece que roda 2 vezes
            SoundManager.Instance.PlayDeathClip();
        }
    }

}
