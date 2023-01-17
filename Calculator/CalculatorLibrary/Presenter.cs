namespace CalculatorLibrary
{
    //презентор
    public class Presenter
    {
        private IView _view;
        private IModel _model;

        //DI с помощью конструктора
        public Presenter(IView view, IModel model)
        {
            _view = view;
            _model = model;
        }

        public void Result()
        {
            double result = _model.Calculate(_view.Value);
            string postfix = _model.PostfixForm;
            _view.Result = $"{postfix} : {result}";
        }
    }
}
