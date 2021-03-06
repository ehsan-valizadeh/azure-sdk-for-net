//****************************************
// This file was autogenerated by a tool.
// Do not modify it.
//****************************************
namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Job Preparation task to run before any tasks of the job on any given compute node.
    /// </summary>
    public partial class JobPreparationTask : ITransportObjectProvider<Models.JobPreparationTask>, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<string> CommandLineProperty;
            public readonly PropertyAccessor<TaskConstraints> ConstraintsProperty;
            public readonly PropertyAccessor<IList<EnvironmentSetting>> EnvironmentSettingsProperty;
            public readonly PropertyAccessor<string> IdProperty;
            public readonly PropertyAccessor<bool?> RerunOnComputeNodeRebootAfterSuccessProperty;
            public readonly PropertyAccessor<IList<ResourceFile>> ResourceFilesProperty;
            public readonly PropertyAccessor<bool?> RunElevatedProperty;
            public readonly PropertyAccessor<bool?> WaitForSuccessProperty;

            public PropertyContainer() : base(BindingState.Unbound)
            {
                this.CommandLineProperty = this.CreatePropertyAccessor<string>("CommandLine", BindingAccess.Read | BindingAccess.Write);
                this.ConstraintsProperty = this.CreatePropertyAccessor<TaskConstraints>("Constraints", BindingAccess.Read | BindingAccess.Write);
                this.EnvironmentSettingsProperty = this.CreatePropertyAccessor<IList<EnvironmentSetting>>("EnvironmentSettings", BindingAccess.Read | BindingAccess.Write);
                this.IdProperty = this.CreatePropertyAccessor<string>("Id", BindingAccess.Read | BindingAccess.Write);
                this.RerunOnComputeNodeRebootAfterSuccessProperty = this.CreatePropertyAccessor<bool?>("RerunOnComputeNodeRebootAfterSuccess", BindingAccess.Read | BindingAccess.Write);
                this.ResourceFilesProperty = this.CreatePropertyAccessor<IList<ResourceFile>>("ResourceFiles", BindingAccess.Read | BindingAccess.Write);
                this.RunElevatedProperty = this.CreatePropertyAccessor<bool?>("RunElevated", BindingAccess.Read | BindingAccess.Write);
                this.WaitForSuccessProperty = this.CreatePropertyAccessor<bool?>("WaitForSuccess", BindingAccess.Read | BindingAccess.Write);
            }

            public PropertyContainer(Models.JobPreparationTask protocolObject) : base(BindingState.Bound)
            {
                this.CommandLineProperty = this.CreatePropertyAccessor(
                    protocolObject.CommandLine,
                    "CommandLine",
                    BindingAccess.Read | BindingAccess.Write);
                this.ConstraintsProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.Constraints, o => new TaskConstraints(o)),
                    "Constraints",
                    BindingAccess.Read | BindingAccess.Write);
                this.EnvironmentSettingsProperty = this.CreatePropertyAccessor(
                    EnvironmentSetting.ConvertFromProtocolCollection(protocolObject.EnvironmentSettings),
                    "EnvironmentSettings",
                    BindingAccess.Read | BindingAccess.Write);
                this.IdProperty = this.CreatePropertyAccessor(
                    protocolObject.Id,
                    "Id",
                    BindingAccess.Read | BindingAccess.Write);
                this.RerunOnComputeNodeRebootAfterSuccessProperty = this.CreatePropertyAccessor(
                    protocolObject.RerunOnNodeRebootAfterSuccess,
                    "RerunOnComputeNodeRebootAfterSuccess",
                    BindingAccess.Read | BindingAccess.Write);
                this.ResourceFilesProperty = this.CreatePropertyAccessor(
                    ResourceFile.ConvertFromProtocolCollection(protocolObject.ResourceFiles),
                    "ResourceFiles",
                    BindingAccess.Read | BindingAccess.Write);
                this.RunElevatedProperty = this.CreatePropertyAccessor(
                    protocolObject.RunElevated,
                    "RunElevated",
                    BindingAccess.Read | BindingAccess.Write);
                this.WaitForSuccessProperty = this.CreatePropertyAccessor(
                    protocolObject.WaitForSuccess,
                    "WaitForSuccess",
                    BindingAccess.Read | BindingAccess.Write);
            }
        }

        private readonly PropertyContainer propertyContainer;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="JobPreparationTask"/> class.
        /// </summary>
        public JobPreparationTask()
        {
            this.propertyContainer = new PropertyContainer();
        }

        internal JobPreparationTask(Models.JobPreparationTask protocolObject)
        {
            this.propertyContainer = new PropertyContainer(protocolObject);
        }

        #endregion Constructors

        #region JobPreparationTask

        /// <summary>
        /// Gets or sets the command line.
        /// </summary>
        public string CommandLine
        {
            get { return this.propertyContainer.CommandLineProperty.Value; }
            set { this.propertyContainer.CommandLineProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the execution constraints provided by the user for this Job Preparation task.
        /// </summary>
        public TaskConstraints Constraints
        {
            get { return this.propertyContainer.ConstraintsProperty.Value; }
            set { this.propertyContainer.ConstraintsProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the collection of EnvironmentSetting instances.
        /// </summary>
        public IList<EnvironmentSetting> EnvironmentSettings
        {
            get { return this.propertyContainer.EnvironmentSettingsProperty.Value; }
            set
            {
                this.propertyContainer.EnvironmentSettingsProperty.Value = ConcurrentChangeTrackedModifiableList<EnvironmentSetting>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string Id
        {
            get { return this.propertyContainer.IdProperty.Value; }
            set { this.propertyContainer.IdProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets whether the Batch service should rerun the Job Preparation task after a compute node reboots.
        /// </summary>
        /// <remarks>
        /// The Job Preparation task is always rerun if a compute node is reimaged, or if the Job Preparation task did not 
        /// complete (e.g. because the reboot occurred while the task was running). Therefore, you should always write a 
        /// Job Preparation task to be idempotent and to behave correctly if run multiple times. If this property is not 
        /// specified, a default value of true is assigned by the Batch service.
        /// </remarks>
        public bool? RerunOnComputeNodeRebootAfterSuccess
        {
            get { return this.propertyContainer.RerunOnComputeNodeRebootAfterSuccessProperty.Value; }
            set { this.propertyContainer.RerunOnComputeNodeRebootAfterSuccessProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a list of files that the Batch service will download to the compute node before running the command 
        /// line.
        /// </summary>
        public IList<ResourceFile> ResourceFiles
        {
            get { return this.propertyContainer.ResourceFilesProperty.Value; }
            set
            {
                this.propertyContainer.ResourceFilesProperty.Value = ConcurrentChangeTrackedModifiableList<ResourceFile>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets whether to run the task in elevated mode.
        /// </summary>
        public bool? RunElevated
        {
            get { return this.propertyContainer.RunElevatedProperty.Value; }
            set { this.propertyContainer.RunElevatedProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets whether the Batch service should wait for the successful completion of the Job Preparation task 
        /// before scheduling any tasks on the compute node.
        /// </summary>
        /// <remarks>
        /// A Job Preparation task execution is considered successful if its ExitCode is 0. If this property is not specified, 
        /// a default value of true is assigned by the Batch service.
        /// </remarks>
        public bool? WaitForSuccess
        {
            get { return this.propertyContainer.WaitForSuccessProperty.Value; }
            set { this.propertyContainer.WaitForSuccessProperty.Value = value; }
        }

        #endregion // JobPreparationTask

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            get { return this.propertyContainer.HasBeenModified; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return this.propertyContainer.IsReadOnly; }
            set { this.propertyContainer.IsReadOnly = value; }
        }

        #endregion //IPropertyMetadata

        #region Internal/private methods
        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.JobPreparationTask ITransportObjectProvider<Models.JobPreparationTask>.GetTransportObject()
        {
            Models.JobPreparationTask result = new Models.JobPreparationTask()
            {
                CommandLine = this.CommandLine,
                Constraints = UtilitiesInternal.CreateObjectWithNullCheck(this.Constraints, (o) => o.GetTransportObject()),
                EnvironmentSettings = UtilitiesInternal.ConvertToProtocolCollection(this.EnvironmentSettings),
                Id = this.Id,
                RerunOnNodeRebootAfterSuccess = this.RerunOnComputeNodeRebootAfterSuccess,
                ResourceFiles = UtilitiesInternal.ConvertToProtocolCollection(this.ResourceFiles),
                RunElevated = this.RunElevated,
                WaitForSuccess = this.WaitForSuccess,
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}