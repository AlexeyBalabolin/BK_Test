using Factory;
using Logic;
using UnityEngine;

namespace View
{
    public interface IView
    {
        void RegisterObject(InteractiveObject CreatedObject, IFactory factory);
    }
}

