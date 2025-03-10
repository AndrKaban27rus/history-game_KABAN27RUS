using JetBrains.Annotations;
using UnityEngine;

public class OpenClose : MonoBehaviour, IInteractable
{
    public Animator m_animator;
    public bool IsOpen;

    void Start()
    {
        if (IsOpen)
            m_animator.SetBool("IsOpen", true);

    }
    public string GetDescription()
    {
        if (IsOpen) return "������� [E], ����� �������";
        return "������� [E], ����� �������";
    }
    public void Interact()
    {
        IsOpen = !IsOpen;
        if (IsOpen)
            m_animator.SetBool("IsOpen", true);
        else
            m_animator.SetBool("IsOpen", false);
    }
}


   

