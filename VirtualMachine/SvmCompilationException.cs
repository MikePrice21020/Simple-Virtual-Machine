namespace SVM.VirtualMachine
{
    #region Using directives
    using System;
    using System.Runtime.Serialization;
    #endregion
    /// <summary>
    /// Exception class used to indicate that an exceptional circumstance
    /// has arisen in compiling an SML program
    /// </summary>
    [Serializable]
    public class SvmCompilationException :Exception
    {
        #region Constants
        private const string msg = "The SML program could not be compiled. ";
        #endregion

        #region Fields
        #endregion

        #region Constructors
        public SvmCompilationException() : base(msg) { }
        public SvmCompilationException(string message) : base(msg + message) { }
        public SvmCompilationException(string message, Exception innerException) : base(msg + message, innerException) { }
        protected SvmCompilationException(SerializationInfo info, StreamingContext context) : base(info, context) { }
        #endregion

        #region Properties
        #endregion

        #region Public methods
        #endregion

        #region Non-public methods
        #endregion

        #region System.Object overrides
        /// <summary>
        /// Determines whether the specified <see cref="System.Object">Object</see> is equal to the current <see cref="System.Object">Object</see>.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object">Object</see> to compare with the current <see cref="System.Object">Object</see>.</param>
        /// <returns><b>true</b> if the specified <see cref="System.Object">Object</see> is equal to the current <see cref="System.Object">Object</see>; otherwise, <b>false</b>.</returns>
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        /// <summary>
        /// Serves as a hash function for this type.
        /// </summary>
        /// <returns>A hash code for the current <see cref="System.Object">Object</see>.</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Returns a <see cref="System.String">String</see> that represents the current <see cref="System.Object">Object</see>.
        /// </summary>
        /// <returns>A <see cref="System.String">String</see> that represents the current <see cref="System.Object">Object</see>.</returns>
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}
