namespace SVM.VirtualMachine
{
    #region Using directives
    using System;
    using System.Collections;
    #endregion
    /// <summary>
    /// TODO: Describe the purpose of this class here
    /// </summary>
    public abstract class BaseInstruction: IInstruction
    {
        #region Constants
        protected const string StackUnderflowMessage = "A stack underflow error has occurred. ( at [line {0}] {1})";
        protected const string OperandOfWrongTypeMessage = "The operand on the stack is of the wrong type. (at [line {0}] {1} )";
        protected const string VirtualMachineErrorMessage = "A virtual machine error has occurred.";
        protected const string InvalidStackNotImage = " The value on top of the stack is not an image.";
        #endregion

        #region Fields
        private IVirtualMachine virtualMachine = null;
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
            return this.GetType().Name;
        }
        #endregion

        #region IInstruction Members
        public abstract void Run();

        public IVirtualMachine VirtualMachine
        {
            get
            {
                return virtualMachine;
            }
            set
            {
                if (null == value)
                {
                    throw new SvmRuntimeException(VirtualMachineErrorMessage);
                }
                virtualMachine = value;
            }
        }
        #endregion
    }
}
