﻿namespace Infrastructure.Data.Models;

/// <summary>
/// Interface which should be implemented by tasks run on startup
/// </summary>
public partial interface IStartupTask
{
    /// <summary>
    /// Executes a task
    /// </summary>
    void Execute();

    /// <summary>
    /// Gets order of this startup task implementation
    /// </summary>
    int Order { get; }
}