﻿namespace ApplyQueryAttributes.Helpers.Views.Utilities
{
    /// <summary>
    /// Marks a type as requiring asynchronous initialization and provides the result of that initialization.
    /// </summary>
    public interface IAsyncInitialization
    {
        /// <summary>
        /// The result of the asynchronous initialization of this instance.
        /// </summary>
        Task Initialisation { get; }
    }
}
