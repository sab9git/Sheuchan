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
using Sheuchan.Sheuchan.Constants;

namespace Sheuchan.Sheuchan.UI.ArableModule.ArableRibbonView
{
    public partial class ArableRibbonView : UserControl, IArableRibbonView
    {

        #region Properties and Fields
        public ArableWorkspace CurrentWorkspace { get; set; }
        public ArableRibbonViewPresenter Presenter { get; set; }
        public MetroFramework.MetroColorStyle ModuleColour { get; set; }

        public MetroTile TileDefineField { get; set; }
        public MetroTile TileFieldManager { get; set; }
        public MetroTile TileCropRotation { get; set; }
        #endregion

        #region Constructor
        public ArableRibbonView(ArableWorkspace workspace)
        {
            InitializeComponent();
            CurrentWorkspace = workspace;
            ModuleColour = ShConstants._modColour1;

            TileDefineField = tileDefineField;
            TileFieldManager = tileFieldManager;
            TileCropRotation = tileCropRotation;
            Initialise();
        }
        #endregion

        #region Methods
        public void Initialise()
        {
            Presenter = new ArableRibbonViewPresenter(this);
            foreach (MetroTile ctrl in this.Controls)
            {
                ctrl.Style = ModuleColour;
            }
        }
        #endregion

        #region Events

        #endregion

        private void tileDefineField_Click(object sender, EventArgs e)
        {
            Presenter.OnDefineFieldClick(sender, e);
        }

        private void tileFieldManager_Click(object sender, EventArgs e)
        {
            Presenter.OnFieldManagerClick(sender, e);
        }

        private void tileCropRotation_Click(object sender, EventArgs e)
        {
            Presenter.OnCropRotationClick(sender, e);
        }
    }
}
