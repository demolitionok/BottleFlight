using UnityEngine;
using Zenject;

public class ViewManagerInstaller : MonoInstaller
{
    [SerializeField]
    private View _startingView;
    [SerializeField]
    private View[] _views;
    
    public override void InstallBindings()
    {
        Container.Bind<IViewManager>().FromInstance(new ViewManager(_startingView, _views)).AsSingle();
    }
}