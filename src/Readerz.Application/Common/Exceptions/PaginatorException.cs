﻿using System;

namespace Readerz.Application.Common.Exceptions
{
    /// <summary>
    /// Represents an paginator exception type.
    /// </summary>
    public class PaginatorException : Exception
    {
        /// <summary>
        /// Instances a new paginator exception object.
        /// </summary>
        /// <param name="message">The actual message.</param>
        public PaginatorException(string message) : base(message)
        {
        }
    }
}