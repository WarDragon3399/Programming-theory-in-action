using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    private void OnMouseDown()
    {
        Talk();
    }

    protected abstract void Talk();
}
