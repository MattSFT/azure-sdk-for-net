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

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    public enum JobOperation
    {
        /// <summary>
        /// Invalid operation type
        /// </summary>
        Invalid = 0,
        
        /// <summary>
        /// Operation type of a backup configuration job.
        /// </summary>
        ConfigureBackup = 1,
        
        /// <summary>
        /// Operation type of a backpu job.
        /// </summary>
        Backup = 2,
        
        /// <summary>
        /// Operation type of a restore job.
        /// </summary>
        Restore = 3,
        
        /// <summary>
        /// Operation type of a job that disables backup.
        /// </summary>
        Unprotect = 4,
        
        /// <summary>
        /// Operation type of a job that deletes backed up data.
        /// </summary>
        DeleteBackupData = 5,
    }
}
