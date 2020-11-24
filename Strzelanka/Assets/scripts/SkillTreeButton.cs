using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillTreeButton : MonoBehaviour
{
    int skillLevel = 0;
    public int maxSkillLevel = 3;
    public int skillTreeLevel;
    public void UpgradeSkill() {
        if (skillLevel < maxSkillLevel) {
            skillLevel++;
        }

        if (skillLevel == maxSkillLevel)
        {
            GetComponent<Image>().color = Color.grey;
            GetComponent<Button>().interactable = false;
        }
    }

    public void UnlockSkillLevel()
    {
        GetComponent<Button>().interactable = true;
    }
}
