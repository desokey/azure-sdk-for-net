// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The AnalyzeBatchInput. </summary>
    internal partial class AnalyzeBatchInput : JobDescriptor
    {
        /// <summary> Initializes a new instance of AnalyzeBatchInput. </summary>
        /// <param name="analysisInput"> Contains a set of input documents to be analyzed by the service. </param>
        /// <param name="tasks"> The set of tasks to execute on the input documents. Cannot specify the same task more than once. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="analysisInput"/> or <paramref name="tasks"/> is null. </exception>
        public AnalyzeBatchInput(MultiLanguageBatchInput analysisInput, JobManifestTasks tasks)
        {
            Argument.AssertNotNull(analysisInput, nameof(analysisInput));
            Argument.AssertNotNull(tasks, nameof(tasks));

            AnalysisInput = analysisInput;
            Tasks = tasks;
        }

        /// <summary> Contains a set of input documents to be analyzed by the service. </summary>
        public MultiLanguageBatchInput AnalysisInput { get; }
        /// <summary> The set of tasks to execute on the input documents. Cannot specify the same task more than once. </summary>
        public JobManifestTasks Tasks { get; }
    }
}
