using UnityEngine;
public class InputManager
{
    private ConstanceInput _constanceInput = new ConstanceInput();

    public float Horizontal { get; private set; }
    public bool Jump { get; private set; }


    public void Update()
    {
        Horizontal = Input.GetAxis(_constanceInput.HORIZONTAL);
        Jump = Input.GetAxis(_constanceInput.JUMP) == 1 ? true : false;
    }
}
