using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject Pattern1;
    public GameObject Pattern2;
    public float StartX = -8.3f;
    public float EndX = 8.3f;

    private void FixedUpdate()
    {
        if (Random.Range(0, 50) == 1)
        {
            Instantiate(Pattern1, new Vector3(Random.Range(StartX, EndX), 6, 0), Pattern1.transform.rotation);
        }

        if (Random.Range(0, 200) == 1)
        {
            Instantiate(Pattern2, new Vector3(Random.Range(StartX, EndX), 6, 0), Pattern2.transform.rotation);
        }
    }
}
