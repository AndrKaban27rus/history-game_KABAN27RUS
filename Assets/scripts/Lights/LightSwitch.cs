using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour, IInteractable
{
    public Light light1;
    public Light light2;
    public Light light3;
    public bool IsOn;
    void Start()
    {
        light1.enabled = IsOn;
        light2.enabled = IsOn;
        light3.enabled = IsOn;
    }

    public string GetDescription()
    {
        if (IsOn) return "������� [E], ����� �������� ����";
        return "������� [E], ����� ��������� ����";
    }
    public void Interact()
    {
        IsOn = !IsOn;
        light1.enabled = IsOn;
        light2.enabled = IsOn;
        light3.enabled = IsOn;
    }
}
