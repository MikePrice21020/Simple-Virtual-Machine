namespace SVM.SimpleMachineLanguage
{
    #region Using directives
    using System;
    using SVM.VirtualMachine;
    #endregion
    /// <summary>
    /// Jumps to the SML instruction labelled by
    /// the branch_location, if the value operand
    /// is less than the integer value on top of the stack
    /// </summary>
    public class Bltint : BaseInstructionWithOperand
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
                int currentNumber = (int)VirtualMachine.Stack.Peek();
                if (Operands.Length > 1)
                {
                    if (int.Parse(Operands[0]) < currentNumber)
                    {
                        VirtualMachine.Conditionals.TryGetValue(Operands[1], out int value);
                        VirtualMachine.GotoLine = value;
                    }
                }
                else
                {
                    throw new SvmRuntimeException(String.Format(BaseInstruction.OperandOfWrongTypeMessage,
                                                    this.ToString(), VirtualMachine.ProgramCounter));
                }
            }
            catch (InvalidCastException)
            {
                throw new SvmRuntimeException(String.Format(BaseInstruction.VirtualMachineErrorMessage,
                                                this.ToString(), VirtualMachine.ProgramCounter));
            }

            #endregion

        }
    }
}
