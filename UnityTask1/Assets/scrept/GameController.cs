using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField,Header("�^�[�Q�b�g�v���n�u")]
    GameObject targetPrefab;

    [SerializeField,Header("�X�|�[���ʒu")]
    Transform  spawnPoint;

    [SerializeField,Header("�X�R�A�I�u�W�F�N�g")]
    GameObject scoreText;

    [SerializeField,Header("�e�L�X�g�I�u�W�F�N�g")]
    GameObject timerText;

    [SerializeField,Header("�{�^��")]
    Button     startButton;

    private int       score          = 0;
    private float     timeLimit      = 5f;
    private bool      isGameRunning  = false;
    private float     timeRemaining;


    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(StartGame);
        timeRemaining = timeLimit;
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameRunning)
        {
            //timeRemaining -= Time.deltaTime;
            timerText.GetComponent<TextMeshProUGUI>().text="Time:"+Mathf.Round(timeRemaining).ToString();

            if(timeRemaining<=0)
            {
                EndGame();
            }
        }
    }

    public void StartGame()
    {
        isGameRunning = true;
        score = 0;
        timeRemaining = timeLimit;
        scoreText.GetComponent<TextMeshProUGUI>().text="Score:" + score;
        startButton.gameObject.SetActive(false);        //START�{�^�����\���ɂ���
        SpawnTarget();

    }

    public void EndGame()
    {
        isGameRunning = false;
        startButton.gameObject.SetActive(true);
        timerText.GetComponent<TextMeshProUGUI>().text = "Game Over";
    }

    public void SpawnTarget()
    {
        //random�Ȉʒu�ɓI���o��
        Vector3 RandomPosition= new Vector3(
            Random.Range(-10f,10f),
            10f,//�������Œ�
            Random.Range(10,30));

        Instantiate(targetPrefab,RandomPosition,Quaternion.identity);
    }


    public void HitTarget()
    {
        if (isGameRunning)
        {
            score+=100;
            scoreText.GetComponent<TextMeshProUGUI>().text="Score:" + score;
            SpawnTarget();
        }
    }
}
