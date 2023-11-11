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
        StartCoroutine(TooltipAnim());
    }

    IEnumerator TooltipAnim()
    {
        tooltipAnim.enabled = false;

        yield return new WaitForSeconds(5f);

        tooltipAnim.enabled = true;
        tooltipAnim.runtimeAnimatorController = animatorTooltip;

        yield return new WaitForSeconds(5f);

        tooltipAnim.runtimeAnimatorController = animatorTooltipleave;
    }

}
