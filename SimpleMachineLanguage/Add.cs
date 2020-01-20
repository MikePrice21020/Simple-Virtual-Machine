namespace SVM.SimpleMachineLanguage
{
    #region Using directives
    using System;
    using SVM.VirtualMachine;
    #endregion
    /// <summary>
    /// Implements the SML Add instruction
    /// Retrieves two integer values from the top of the
    /// stack and adds them together, leaving
    /// the result on the stack
    /// </summary>
    public class Add: BaseInstruction
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
            try
            {
                if (VirtualMachine.Stack.Count < 2)
                {
                    throw new SvmRuntimeException(String.Format(BaseInstruction.StackUnderflowMessage, 
                                                    this.ToString(), VirtualMachine.ProgramCounter));
                }

                int op1 = (int)VirtualMachine.Stack.Pop();
                int op2 = (int)VirtualMachine.Stack.Pop();
                VirtualMachine.Stack.Push(op1 + op2);
            }
            catch (InvalidCastException)
            {
                throw new SvmRuntimeException(String.Format(BaseInstruction.OperandOfWrongTypeMessage, 
                                                this.ToString(), VirtualMachine.ProgramCounter));
            }
        }

        #endregion
    }
}
