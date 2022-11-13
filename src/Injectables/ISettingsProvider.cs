namespace JoaLauncher.Api.Injectables;

public interface ISettingsProvider
{
    public T GetSetting<T>();
}