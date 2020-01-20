namespace SVM.VirtualMachine
{
    #region Using directives
    using System;
    using System.Collections;
    using System.Collections.Generic;
    #endregion

    /// <summary>
    /// Defines the interface contract for all Simple 
    /// Virtual Machine instructions that have an operand
    /// </summary>
    public interface IVirtualMachine
    {
        List<IInstruction> Program { get; set; }
        Stack Stack { get;  }
        int ProgramCounter { get; set; }
        Dictionary<string, int> Conditionals { get;}
        int? GotoLine { get; set; }
    }
}
