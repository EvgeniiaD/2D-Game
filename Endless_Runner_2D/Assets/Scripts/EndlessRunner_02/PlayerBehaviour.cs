using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerBehaviour : MonoBehaviour
{
    [Header("Score")]
    private float score;
    public Text scoreText;
    public GameObject DeadUI;
    public GamingManager theGameManager;

    public float movementSpeed;

    [Header("Movement")]
    private bool movingLeft;
    private float rotationSpeed;

    [Header("Sounds")]
    public AudioSource deathSound;
    public AudioSource moveSound;

    [Header("Spawns")]
    public ObstacleSpawn spawner;
    public treespawner treeSpawner;
    public treespawner treeSpawner2;
    public treespawner luzD;
    public treespawner luzIz;
    public CoinSpawn coinSpawner;
    public AudioSource music;

    [Header("Power Up")]
    private bool invincibleMode;
    private bool isPowerUpActive;
    private float powerUpLengthCounter;
    
    public ParticleSystem particles;

    private bool isDead = false;

    // Use this for initialization
    void Start ()
    {
        particles.Stop();
        score = 0;
        movingLeft = true;

        spawner.disable = false;
        treeSpawner.disable = false;
        treeSpawner2.disable = false;
        luzIz.disable = false;
        luzD.disable = false;
        coinSpawner.coinDisable = false;

        isDead = false;

        /*invincibleMode = false;
        isPowerUpActive = false;*/
    }

    // Update is called once per frame
    void Update()
    {
        if(isDead) return;
         
        score += Time.deltaTime;
        transform.Translate(Vector3.down * Time.deltaTime * movementSpeed);


        if(Input.GetKeyDown(KeyCode.Space))
        {
            rotationSpeed = 1.0f;
            movingLeft = !movingLeft;
            moveSound.Play();
            particles.Play();


        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            particles.Stop();
        }
        if(Input.GetKey(KeyCode.Space))
        {
            rotationSpeed += 1.5f * Time.deltaTime;
        }

        if(movingLeft) transform.Rotate(0, 0, rotationSpeed);
        else transform.Rotate(0, 0, -rotationSpeed);


        /*if(isPowerUpActive)
        {
            powerUpLengthCounter -= Time.deltaTime;
            Physics2D.IgnoreLayerCollision(9, 8, true);

            if(powerUpLengthCounter <= 0)
            {
                isPowerUpActive = false;
            }
        }*/
    }

    void FixedUpdate()
    {
        if(isDead) return;

        scoreText.GetComponent<Text>().text = "Score " + Mathf.Round(score);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!isDead && (other.tag == "Obstacle" || other.tag == "Limit"))
        {
            Die();
            deathSound.Play();
            theGameManager.Dead();
        }
    }

    void Die()
    {
        print("Player dead");
        // Destroy(this.gameObject);
        isDead = true;
        DeadUI.SetActive(true);
        Destroy(spawner);
        spawner.disable = true;
        treeSpawner.disable = true;
        treeSpawner2.disable = true;
        luzIz.disable = true;
        luzD.disable = true;
        coinSpawner.coinDisable = true;
        music.Stop();
    }

    /*public void ActivatePowerUp(bool mode, float time)
    {
        isPowerUpActive = true;
        invincibleMode = true;
        invincibleMode = mode;
        powerUpLengthCounter = time;

    }*/
}
