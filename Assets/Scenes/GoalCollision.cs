using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalCollision : MonoBehaviour
{
    public GameObject basicText, basicTextTwo, basicTextThree, goalText;
    public Vector3 fontSizeText, fontSizeGoalText;
    public float wait = 3f;
    public float timer = 0f;
    public float activeTimer;

    void OnCollisionEnter(Collision goalCollision)
    {
        if (goalCollision.gameObject.name == "GoalBall")
        {
            activeTimer = 5;

            basicText = GameObject.Find("/Canvas/Text");
            basicTextTwo = GameObject.Find("/Canvas/TextTwo");
            basicTextThree = GameObject.Find("/Canvas/TextThree");
            goalText = GameObject.Find("/Canvas/GoalReached");
            fontSizeText = new Vector3(-2f, -2f, -2f);
            fontSizeGoalText = new Vector3(5f, 5f, 5f);
            basicText.transform.localScale += fontSizeText;
            basicTextTwo.transform.localScale += fontSizeText;
            basicTextThree.transform.localScale += fontSizeText;
            goalText.transform.localScale += fontSizeGoalText;
        }
    }
    void Update()
    {
        if (activeTimer == 5)
        {
            timer += Time.deltaTime;

            if (timer >= 5f)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
