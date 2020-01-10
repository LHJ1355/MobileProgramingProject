using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_Health : MonoBehaviour
{
    public int startHealth = 100;
    public int currentHealth = 0;
    public Slider healthSlider;
    public Image damagedImage;
    public float flashSpeed = 5f;
    public Color flashColorr = new Color(1f, 0f, 0f, 0.1f);

    private move playerMovement;

    private bool isDead;
    private bool damaged;

    public GameObject GameOverImage;
    public GameObject RestartButton;

    public void Init()
    {
        startHealth = 100;
        currentHealth = startHealth;
        healthSlider.value = currentHealth;
        isDead = false;
        playerMovement.enabled = true;
    }
    // Start is called before the first frame update
    void Awake()
    {
        playerMovement = GetComponent<move>();
        currentHealth = startHealth;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (damaged)
        {
            damagedImage.color = flashColorr;
        }
        else
        {
            damagedImage.color = Color.Lerp(damagedImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;
    }

    public void TakeDamage(int amount)
    {
        damaged = true;
        currentHealth -= amount;
        healthSlider.value = currentHealth;
        if (currentHealth <= 0 && !isDead)
        {

            Death();
        }
    }

    void Death()
    {
        isDead = true;
        playerMovement.enabled = false;
        GameOverImage.SetActive(true);
        RestartButton.SetActive(true);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }
}

