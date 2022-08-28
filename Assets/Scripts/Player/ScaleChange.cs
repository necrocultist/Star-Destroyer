using UnityEngine;

public class ScaleChange : MonoBehaviour
{
    private Vector3 scaleChangeAmount = new Vector3(0.17f, 0.17f, 0f);

    private void OnEnable()
    {
        GetComponent<PlayerHealth>().OnHealthDecrease += ScaleGrow;
    }

    private void OnDisable()
    {
        GetComponent<PlayerHealth>().OnHealthDecrease -= ScaleGrow;
    }

    private void ScaleGrow()
    {
        transform.localScale += scaleChangeAmount;
    }
}
