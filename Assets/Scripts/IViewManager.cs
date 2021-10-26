
public interface IViewManager
{
    public abstract void ShowView<T>(bool remember = true) where T : View;
}
