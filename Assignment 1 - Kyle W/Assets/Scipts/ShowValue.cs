using UnityEngine;
using UnityEngine.UI;

public class ShowValue : MonoBehaviour
{
    Text percentageText;

    void Start()
    {
        percentageText = GetComponent<Text>();
    }

    public void txtUpdate(float value)
    {
        percentageText.text = Mathf.RoundToInt(value * 100) + "%";
    }
}
