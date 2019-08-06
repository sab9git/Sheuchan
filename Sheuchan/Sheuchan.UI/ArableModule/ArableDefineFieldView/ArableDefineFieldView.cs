using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
namespace Sheuchan.Sheuchan.UI.ArableModule.ArableDefineFieldView
{
    public partial class ArableDefineFieldView : UserControl
    {
        #region Properties
        public MetroGrid GridLatLongPoints { get; set; }

        #endregion

        public ArableDefineFieldView()
        {
            InitializeComponent();
            GridLatLongPoints = gridLatLongPoints;
        }
    }
}
