using System;

namespace MessageMocker.Data
{
    /// <summary>
    ///     Application handled by the program
    /// </summary>
    internal class Application
    {
        /// <summary>
        ///     Name of the application
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Description of the application
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     Identifier of the application
        /// </summary>
        public Guid Identifier { get; set; }
    }
}
