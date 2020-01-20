namespace SML_Extensions
{
    #region Using directives
    using SVM.VirtualMachine;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Drawing;
    using System.Windows.Forms;
    #endregion
    /// <summary>
    /// Implements the SML Loadimage instruction
    /// loadimage from oprand
    /// </summary>
    public class Displayimage : BaseInstruction
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
            int xSize = 960;
            int ySize = 541;

            try
            {
                Bitmap bitmap = (Bitmap)VirtualMachine.Stack.Pop();
                PictureBox pictureBox1 = new PictureBox();
                Form form = new Form();
                pictureBox1.Image = (Image)bitmap;
                pictureBox1.ClientSize = new Size(xSize, ySize);
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                form.Controls.Add(pictureBox1);
                form.SetBounds(100, 100, xSize, ySize);
                form.ShowDialog();
            }
            catch (InvalidCastException)
            {
                throw new SvmRuntimeException(String.Format(BaseInstruction.InvalidStackNotImage,
                                                this.ToString(), VirtualMachine.ProgramCounter));
            }
        }

        #endregion
    }
}
