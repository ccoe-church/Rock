//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//

/** Contains information about the starting or stopping of a task. */
export type TaskActivityProgressStatusBag = {
    /** Additional custom data related to the status of this task. */
    data?: unknown;

    /** The total time elapsed for this task, measured in milliseconds. */
    elapsedMilliseconds: number;

    /** A collection of errors the task encountered while running. */
    errors?: string[] | null;

    /** A flag indicating if this task is finished. */
    isFinished: boolean;

    /** A flag indicating if this task has started. */
    isStarted: boolean;

    /** A message indicating the current state of this task. */
    message?: string | null;

    /** A unique identifier for the task to which this status applies. */
    taskId?: string | null;

    /** The name of the task. */
    taskName?: string | null;

    /** A collection of warnings the task encountered while running. */
    warnings?: string[] | null;
};