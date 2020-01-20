namespace SVM.VirtualMachine
{
    #region Using directives
    using System;
    #endregion

    /// <summary>
    /// Defines the interface contract for all Simple 
    /// Virtual Machine instructions that have an operand
    /// </summary>
    public interface IInstructionWithOperand :IInstruction
    {
        string[] Operands { get; set; }
    }
}
