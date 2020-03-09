﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;

namespace Microsoft.Azure.WebJobs.Host
{
    /// <summary>
    /// Metadata for function Binding
    /// </summary>
    public class BindingMetadata : IUserTextElement, IUserIconElement
    {
        /// <summary>
        /// Gets the binding identifier.
        /// </summary>
        public string Id { get; }

        /// <inheritdoc/>
        public string Summary { get; }

        /// <inheritdoc/>
        public string Description { get; }

        /// <inheritdoc/>
        public string Tooltip { get; }

        /// <inheritdoc/>
        public Uri IconUri { get; }

        /// <inheritdoc/>
        public uint BrandColor { get; }

        /// <summary>
        /// Gets the binding's service operations
        /// </summary>
        public IReadOnlyDictionary<string, ServiceOperation> Operations { get; }

        /// <summary>
        /// Gets the binding's connection metadata
        /// </summary>
        public ConnectionMetadata Connection { get; }
    }
}