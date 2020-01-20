using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SVM;
using SVM.VirtualMachine.Debug;
using SVM.VirtualMachine;

namespace Debuggers
{
    public class Debugger : IDebugger
    {
        #region TASK 5 - TO BE IMPLEMENTED BY THE STUDENT
        private SvmVirtualMachine virtualMachine;
        Debugger_Form UI = new Debugger_Form();
        #endregion
        public SvmVirtualMachine VirtualMachine
        {
            set
            {
                virtualMachine = value;
            }
        }
        public void Break(IDebugFrame debugFrame)
        {
            List<string> stacks = new List<string>();
            IInstruction current = debugFrame.CurrentInstruction;
            List<IInstruction> list = debugFrame.CodeFrame;
            UI.listBox1.DataSource = null;
            UI.listBox2.DataSource = null;

            string currentLineString = current.ToString();
            UI.listBox1.DataSource = debugFrame.CodeFrame;

            foreach (var intstack in virtualMachine.Stack)
            {
                stacks.Add(intstack.ToString());
            }
            UI.listBox2.DataSource = stacks;
            int count = virtualMachine.ProgramCounter;
            UI.listBox1.SelectedItem = current;
            UI.ShowDialog();


        }
    }
}
