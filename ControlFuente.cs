using UnityEngine;
using TMPro;

public class ControlFuente : MonoBehaviour
{
    public TextMeshProUGUI texto;
    public float incremento = 2f;

    public void AumentarFuente()
    {
        texto.fontSize += incremento;
    }

    public void DisminuirFuente()
    {
        texto.fontSize -= incremento;
    }
}
