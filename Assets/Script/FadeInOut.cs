using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour
{
    public Image panelImage;
    public Text EndingText;
    public float timer = 0;

    private void Start()
    {
        StartCoroutine(FadeOut(0.2f));
    }

    public void Update()
    {
        timer += 1;

        if(timer > 460)
        {
            StartCoroutine(FadeIn(0.2f));
        }
    }

    // FadeIn Effect
    public IEnumerator FadeIn(float targetAlpha)
    {
        // To Set panelImage Color.Alpha to 0
        panelImage.color = new Color(panelImage.color.r, panelImage.color.g, panelImage.color.b, 0);
        EndingText.color = new Color(204, 200, 200, 0);

        // While Color.Alpha < 1, Loop until > 1 and Finished FadeIn
        while (panelImage.color.a < 1.0f)
        {
            panelImage.color = new Color(panelImage.color.r, panelImage.color.g, panelImage.color.b, panelImage.color.a + (0.01f / targetAlpha));
            yield return null;
        }

        while (EndingText.color.a < 1.0f)
        {
            EndingText.color = new Color(204, 200, 200, EndingText.color.a + (0.0045f / targetAlpha));
            yield return null;
        }
    }

    // FadeOut Effect
    public IEnumerator FadeOut(float targetAlpha)
    {
        // To Set panelImage Color.Alpha to 1
        panelImage.color = new Color(panelImage.color.r, panelImage.color.g, panelImage.color.b, 1);

        // While Color.Alpha > 0, Loop until < 0 and Finished FadeOut
        while (panelImage.color.a > 0.0f)
        {
            panelImage.color = new Color(panelImage.color.r, panelImage.color.g, panelImage.color.b, panelImage.color.a - (0.0045f / targetAlpha));
            yield return null;
        }
    }
}
