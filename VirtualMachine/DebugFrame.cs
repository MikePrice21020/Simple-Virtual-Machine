using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SVM;
using SVM.VirtualMachine;
using SVM.VirtualMachine.Debug;

namespace SVM.VirtualMachine
{
    class DebugFrame : IDebugFrame
    {
        private IInstruction currentInstruction;

        private List<IInstruction> codeFrame;
        public DebugFrame(IInstruction current, List<IInstruction> List)
        {
            currentInstruction = current;
            codeFrame = List;
        }
        public IInstruction CurrentInstruction
        {
            get
            {
                return currentInstruction;
            }
        }
        public List<IInstruction> CodeFrame
        {
            get
            {
                return codeFrame;
            }
        }
    }
}
