using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using Sheuchan.Sheuchan.Constants;
using Sheuchan.Sheuchan.HelperClasses;
using Sheuchan.Sheuchan.UI.ShellRibbon;
using Sheuchan.Sheuchan.UI;

namespace Sheuchan
{
    public partial class ShellForm : Form, IShellForm
    {
        #region Properties and Fields
        public IShellFormPresenter Presenter { get; set; }
        public IShellRibbonView MainRibbonBar { get; set;
        }
        //------ UI Elements
        public MetroPanel RibbonZone { get; set; }
        public MetroPanel MainZone { get; set; }

        //------ Workspaces
        public List<string> InitialisedWorkspaces { get; set; }
        public List<UserControl> Modules { get; set; }

        #endregion

        #region Constructor
        public ShellForm()
        {
            InitializeComponent();
            this.Text = ShConstants._applicationName;
            Presenter = new ShellFormPresenter(this);

            // Match UI Panels to their Properties
            RibbonZone = mpnlRibbonZone;
            MainZone = mpnlMainZone;

            // Very Basic UI Initialisations
            mlblStephenBrown.Text = "Stephen Brown   - " + DateTime.Now.ToString("MMMM") + " " + DateTime.Now.Year.ToString();

            // Initialise the Environment and Startup
            OnStartup();
        }
        #endregion

        #region Methods

        /// <summary>
        /// Initial Startup of the ShellForm should Inject the Main RibbonBar and Tiles, 
        /// and apply the associated colours, styles and labels to them as defined in the ShConstants
        /// class
        /// </summary>
        /// <remarks
        /// Author  : Stephen Brown
        /// Date    : 30/07/2019
        /// </remarks>
        public void OnStartup()
        {
            MainRibbonBar = new ShellRibbonView(this);
            ControlInjector.InjectIntoZone((UserControl)MainRibbonBar, RibbonZone);

            MainRibbonBar.Module1Tile.Style = ShConstants._modColour1;
            MainRibbonBar.Module2Tile.Style = ShConstants._modColour2;
            MainRibbonBar.Module3Tile.Style = ShConstants._modColour3;
            MainRibbonBar.Module4Tile.Style = ShConstants._modColour4;

            MainRibbonBar.Module1Tile.Text = ShConstants._module1Name;
            MainRibbonBar.Module2Tile.Text = ShConstants._module2Name;
            MainRibbonBar.Module3Tile.Text = ShConstants._module3Name;
            MainRibbonBar.Module4Tile.Text = ShConstants._module4Name;

            InitialisedWorkspaces = new List<string>();
            Modules = new List<UserControl>();
        }

        #endregion

        #region Events
        #endregion
    }
}
