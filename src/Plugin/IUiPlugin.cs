﻿namespace JoaLauncher.Api.Plugin;

public interface IUiPlugin : IPlugin
{
    void Start(string port);
    void Stop();
}