using UnityEngine;

//ввод с клавиатуры
public class KeyboardInput : IInput
{
    public Vector3 InputAxis { get => Convert();}

    private Vector3 Convert()
    {
        Vector3 inputVector = Vector3.zero;

        //ввод стрелками или клавишами WASD
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        inputVector += new Vector3(horizontal, 0, vertical);

        return inputVector;
    }
}

