using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sheuchan.Sheuchan.UI
{
    public partial class ExampleMainPanel : UserControl
    {
        public MetroFramework.Controls.MetroTile ExampleTile {get; set;}
        public ExampleMainPanel()
        {
            InitializeComponent();
            ExampleTile = tileExample;
        }
    }
}
