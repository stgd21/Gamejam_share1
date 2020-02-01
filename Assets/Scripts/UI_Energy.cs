using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Energy: MonoBehaviour
{
    public Slider energySlider;

    public void SetEnergy(float newEnergy)
    {
        energySlider.value = newEnergy;
    }

}
