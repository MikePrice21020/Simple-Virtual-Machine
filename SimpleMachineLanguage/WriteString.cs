namespace SVM.SimpleMachineLanguage
{
    #region Using directives
    using System;
    using SVM.VirtualMachine;
    #endregion
    /// <summary>
    /// Implements the SML WriteString instruction
    /// Retrieves the value from the top of the stack
    /// and writes it out to the console as a string
    /// </summary>
    public class WriteString: BaseInstruction
    {
        #region Constants
        #endregion

        #region Fields
        #endregion

        #region Constructors
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

        #region IInstruction Members

        public override void Run()
        {
            if (VirtualMachine.Stack.Count < 1)
            {
                throw new SvmRuntimeException(String.Format(BaseInstruction.StackUnderflowMessage, 
                                                this.ToString(), VirtualMachine.ProgramCounter));
            }

            Console.WriteLine(VirtualMachine.Stack.Pop().ToString());
        }

        #endregion
    }
}
