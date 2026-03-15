using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 MovementValue;
    int score = 0;
    int lifes = 3;
    public TMPro.TextMeshProUGUI scoreTxt;
    public TMPro.TextMeshProUGUI lifesTxt;
    void OnMove(InputValue value)
    {
        MovementValue = value.Get<Vector2>();
    }
    private void FixedUpdate()
    {
        Vector3 direction = new Vector3(MovementValue.x, 0, 0);
        Vector3 move = direction * speed * Time.fixedDeltaTime;

        transform.Translate(move);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);

        if (collision.gameObject.CompareTag("Collectiable"))
        {
            score++;
            scoreTxt.text = "Score: " + score;
        }

        if (collision.gameObject.CompareTag("Uncollectiable"))
        {
            lifes--;
            lifesTxt.text = "Lifes: " + lifes;

            if (lifes == 0)
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }
}
