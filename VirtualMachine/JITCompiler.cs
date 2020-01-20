namespace SVM.VirtualMachine
{
    #region Using directives
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using System.Threading;
    #endregion
    /// <summary>
    /// Utility class which generates compiles a textual representation
    /// of an SML instruction into an executable instruction instance
    /// </summary>
    internal static class JITCompiler
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
        [DllImport("mscoree.dll", CharSet = CharSet.Unicode)]
        static extern bool StrongNameSignatureVerificationEx(string filePath, bool forcingVerification, ref bool checkVerification);
        internal static IInstruction CompileInstruction(string opcode)
        {

            //var myEnviroment = System.Environment.CurrentDirectory;
            bool verification = false;
            IInstruction instruction = null;
            var myAssemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();
            var files = Directory.GetFiles(System.Environment.CurrentDirectory, "*.dll").ToList();
            try
            {
                foreach (var current in files)
                {
                    if (StrongNameSignatureVerificationEx(current, true, ref verification))
                    {
                        myAssemblies.Add(Assembly.LoadFrom(current));
                    }
                }
            }
            catch
            {
                // Ignores the fact it cant load .NET assembly
            }
            foreach (Assembly currentassembly in myAssemblies)
            {

                Type[] types = currentassembly.GetTypes();

                foreach (Type currentype in types)
                {
                    if (currentype.Name.ToLower() == opcode.ToLower())
                    {
            
                        instruction = (IInstruction)Activator.CreateInstance(currentype);
                        return instruction;

                    }
                }
            }
            #region TASK 1 - TO BE IMPLEMENTED BY THE STUDENT
            #endregion

            throw new SvmCompilationException();
        }

        internal static IInstruction CompileInstruction(string opcode, params string[] operands)
        {
            bool verification = false;
            IInstructionWithOperand instruction = null;

            var myAssemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();
            var files = Directory.GetFiles(System.Environment.CurrentDirectory, "*.dll").ToList();
            try
            {
                foreach (var current in files)
                {
                    if (StrongNameSignatureVerificationEx(current, true, ref verification))
                    {
                        myAssemblies.Add(Assembly.LoadFrom(current));
                    }
                }
            }
            catch
            {
                // Ignores the fact it cant load .NET assembly
            }

            foreach (Assembly currentassembly in myAssemblies)
            {

                Type[] types = currentassembly.GetTypes();

                foreach (Type currentype in types)
                {
                    if (currentype.Name.ToLower() == opcode.ToLower())
                    {

                        //typed.MyFunction();
                        instruction = (IInstructionWithOperand)Activator.CreateInstance(currentype);
                        instruction.Operands = operands;
                        return instruction;

                    }
                }

            }

            #region TASK 1 - TO BE IMPLEMENTED BY THE STUDENT
            #endregion

            throw new SvmCompilationException();
        }
        #endregion

    }
}
