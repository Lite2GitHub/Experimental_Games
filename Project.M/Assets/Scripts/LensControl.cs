using UnityEngine;

public class LensControl : MonoBehaviour
{
    public GameObject Lens;
    bool isLensUp = false;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (!isLensUp)
            {
                LensReady();
                isLensUp = true;
            }
            else
            {
                LensUnready();
                isLensUp = false;
            }
        }
    }

    public void LensReady()
    {
        Lens.SetActive(true); // lens on
    }

    public void LensUnready() // able to set a other ways to control the lens, i.e timer
    {
        Lens.SetActive(false); // lens off
    }
}
