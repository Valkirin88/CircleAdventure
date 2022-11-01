using Zenject;

public class Installer : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<ColliderHandler>().To<ColliderHandler>().AsSingle().NonLazy();
    }
}