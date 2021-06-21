using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;

    public float distance = 0;
    public string scoreCount;
    public string percentage = "%";

    public GameObject object1;
    public GameObject object2;

    // Update is called once per frame
    void Update()
    {
        float distance = (object2.transform.position.z - object1.transform.position.z);

        if (distance >= 1)
        {
            scoreCount = (100 - (distance / 30)).ToString("0");
            scoreText.text = scoreCount + percentage;
        }
    }

}
