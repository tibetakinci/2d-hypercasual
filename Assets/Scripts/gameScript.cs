using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameScript : MonoBehaviour
{
    public GameObject ball;
    public GameObject diamond;

    public float ballSpeed;
    private float Timer = 1;
    private bool right = true;
    public bool isPlaying = false;

    private Stack score = new Stack();
    private float leftEdge = -8.6f;
    private float rightEdge = 8.6f;
    private int points = 0;
    private GameObject scoreText;


    void Start()
    {
        isPlaying = true;
        diamond.SetActive(false);
        scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlaying)
        {
            ballMovement();
            diamondDrop();
            scoreBoard();
        }
    }

    void ballMovement()
    {
        if (ball.transform.position.x < 8.63 && right)
        {
            //Debug.Log(transform.position.x);
            ball.transform.Translate(Vector3.right * ballSpeed);
        }
        else
        {
            right = false;
        }

        if (ball.transform.position.x > -8.63 && !right)
        {
            //Debug.Log(transform.position.x);
            ball.transform.Translate(Vector3.left * ballSpeed);
        }
        else
        {
            right = true;
        }

        if (Input.GetKeyDown("space"))
        {
            if (right)
            {
                right = false;
            }
            else
            {
                right = true;
            }
        }
    }

    void diamondDrop()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            float number = UnityEngine.Random.Range(8.4f, -8.4f);
            GameObject newObj = Instantiate(diamond, new Vector3(number, 2.5f, 0), Quaternion.identity);
            newObj.SetActive(true);
            Destroy(newObj, 1.08f);
            Timer = 0.8f;
        }
    }

    void loadGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public int scoreBoard(){

        

        if (ball.transform.position.x < leftEdge && score.Count == 0){
            score.Push(leftEdge);
        }
        else if (ball.transform.position.x > rightEdge && score.Count == 0){
            score.Push(rightEdge);
        }

        if ((ball.transform.position.x < leftEdge) && ((float)score.Peek() != leftEdge))
        {
           // score.Pop();
            score.Push(leftEdge);
            points = points + 1;
        }
        if ((ball.transform.position.x > rightEdge) && ((float)score.Peek() != rightEdge))
        {
          //  score.Pop();
            score.Push(rightEdge);
            points = points + 1;
        }
        Debug.Log(points);
        Debug.Log(score.Count);

        scoreText.GetComponent<UnityEngine.UI.Text>().text = points.ToString();
        
        
        return points;
    } 
}
