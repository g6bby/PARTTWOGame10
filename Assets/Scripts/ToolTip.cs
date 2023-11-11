using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolTip : MonoBehaviour
{
    public GameObject tooltipUI;
    public Animator tooltipAnim;
    public RuntimeAnimatorController animatorTooltip;
    public RuntimeAnimatorController animatorTooltipleave;

    void Start()
    {
        tooltipAnim.runtimeAnimatorController = animatorTooltip;

        StartCoroutine(TooltipAnim());
    }

    IEnumerator TooltipAnim()
    {
        yield return new WaitForSeconds(2f);

        tooltipAnim.runtimeAnimatorController = animatorTooltipleave;
    }

}
