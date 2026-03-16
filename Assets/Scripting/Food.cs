using UnityEngine;

public class Food : MonoBehaviour
{
    private void Start()
    {
        Respawn();
    }

    public void Respawn()
    {
        Vector2 newPos;
        do
        {
            float x = Random.Range(-8f, 8f);
            float y = Random.Range(-8f, 8f);
            newPos = new Vector2(Mathf.Round(x), Mathf.Round(y));
        }
        while (Physics2D.OverlapCircle(newPos, 0.1f) != null);

        this.transform.position = newPos;
    }
}