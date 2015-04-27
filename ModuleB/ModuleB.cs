using System;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.MefExtensions.Modularity;
using Microsoft.Practices.Prism.Modularity;
using ModuleTracking;
using SageConcept.Core;

namespace ModuleB
{

    /// <summary>
    /// A module for the quickstart.
    /// </summary>
    [ModuleExport(typeof(ModuleB))]
    public class ModuleB : IModule
    {
        private readonly IModuleTracker moduleTracker;

        /// <summary>
        /// Initializes a new instance of the <see cref="ModuleB"/> class.
        /// </summary>
        /// <param name="moduleTracker">The module tracker.</param>
        [ImportingConstructor]
        public ModuleB(IModuleTracker moduleTracker)
        {
            if (moduleTracker == null)
            {
                throw new ArgumentNullException("moduleTracker");
            }

            this.moduleTracker = moduleTracker;
            this.moduleTracker.RecordModuleConstructed(WellKnownModuleNames.ModuleB);
        }

        /// <summary>
        /// Notifies the module that it has be initialized.
        /// </summary>
        public void Initialize()
        {
            this.moduleTracker.RecordModuleInitialized(WellKnownModuleNames.ModuleB);
        }
    }
}
