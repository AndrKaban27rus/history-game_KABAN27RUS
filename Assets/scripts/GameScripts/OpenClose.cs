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
        if (IsOpen) return "Нажмите [E], чтобы закрыть";
        return "Нажмите [E], чтобы открыть";
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


   

