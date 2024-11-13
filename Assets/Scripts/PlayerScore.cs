using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public GameObject player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.transform.position.z.ToString("0");
    }
}
