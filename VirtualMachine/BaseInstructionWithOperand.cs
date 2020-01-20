namespace SVM.VirtualMachine
{
    #region Using directives
    using System;
    using System.Collections;
    using System.Collections.Generic;
    #endregion
    /// <summary>
    /// TODO: Describe the purpose of this class here
    /// </summary>
    public abstract class BaseInstructionWithOperand: BaseInstruction, IInstructionWithOperand
    {
        #region Constants
        protected const string InvalidOperandMessage = "An invalid operand was supplied.";
        #endregion

        #region Fields
        private List<string> operand = new List<string>();
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
            string str = this.GetType().Name;
            foreach (string operand in Operands)
            {
                str = str + " " + operand;
            }
            return str;
        }
        #endregion


        #region IInstructionWithOperand Members

        public string[] Operands
        {
            get
            {
                return operand.ToArray();
            }
            set
            {
                if (null == value)
                {
                    throw new SvmCompilationException(InvalidOperandMessage);
                }
                operand.AddRange(value);
            }
        }

        #endregion
    }
}
