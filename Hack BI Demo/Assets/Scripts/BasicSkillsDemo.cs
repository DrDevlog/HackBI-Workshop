using UnityEngine;

public class BasicSkillsDemo : MonoBehaviour
{
    private Rigidbody rb;
    private int score = 0;
    [SerializeField]
    private float speed = 10.5f;
    [SerializeField]
    private string playerName = "John";

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1, 0, 0);
    }

    void Update()
    {
        score++;
        playerName = "James";
        MoveObject(Vector3.right, 5f);
    }

    private void MoveObject(Vector3 direction, float speed)
    {
        transform.Translate(direction * (speed * Time.deltaTime));
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 20), "Score: " + score);
        GUI.Label(new Rect(10, 30, 200, 20), "Player Name: " + playerName);
    }
}