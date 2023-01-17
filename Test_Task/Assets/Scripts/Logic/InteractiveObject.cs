using UnityEngine;

namespace Logic
{
    //класс с композицией скрытия объектов, выбора и изменения прозрачности
    public abstract class InteractiveObject : MonoBehaviour
    {
        protected IAlphaChange _alphaChange;
        protected ISelect _select;
        protected IHide _hide;

        public void Construct(IAlphaChange alphaChange, ISelect select, IHide hide)
        {
            _alphaChange = alphaChange;
            _select = select;
            _hide = hide;
        }

        public void ChangeAlpha(float alphaLevel) => _alphaChange.SetAlpha(alphaLevel);
        public void Select() => _select.Select();
        public void Deselect() => _select.Deselect();
        public void Hide() => _hide.Hide();
        public void Show() => _hide.Show();
    }
}

