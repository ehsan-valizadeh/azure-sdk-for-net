// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

namespace Microsoft.Azure.Batch.Common
{
    using System;
    using System.Linq;
    
    /// <summary>
    /// The state of a start task on a compute node.
    /// </summary>
    public enum StartTaskState
    {
        /// <summary>
        /// The start task is currently running.
        /// </summary>
        Running,
        
        /// <summary>
        /// The start task has exited with exit code 0, or the start task has
        /// failed and the retry limit has reached, or the start task process
        /// did not run due to scheduling errors.
        /// </summary>
        Completed,
    }
}
