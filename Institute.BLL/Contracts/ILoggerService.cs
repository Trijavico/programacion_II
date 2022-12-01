﻿
using Institute.BLL.Core;


namespace Institute.BLL.Contracts
{
    /// <summary>
    /// Interfaz los logs de los servicios.
    /// </summary>
    public interface ILoggerService<TService> where TService : IBaseService
    {
        void LogError(string message, params object[] args);
        void LogInformation(string message, params object[] args);
        void LogDebug(string message, params object[] args);
        void LogWarning(string message, params object[] args);
    }
}
