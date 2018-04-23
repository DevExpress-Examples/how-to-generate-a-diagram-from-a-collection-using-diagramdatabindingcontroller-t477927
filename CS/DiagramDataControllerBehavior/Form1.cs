using DiagramDataControllerBehavior.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiagramDataControllerBehavior
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            diagramDataBindingController1.DataSource = ClassStructureGenerator.ClassList();
            diagramDataBindingController1.ConnectorsSource = ClassStructureGenerator.ConnectionList();
           
        }

        private void diagramDataBindingController1_GenerateConnector(object sender, DevExpress.XtraDiagram.DiagramGenerateConnectorEventArgs e)
        {
            if (((ClassData)e.From).Type == ClassType.Interface || ((ClassData)e.To).Type == ClassType.Interface)
                e.Connector = e.CreateConnectorFromTemplate("InterfaceConnector");
            else e.Connector = e.CreateConnectorFromTemplate("ClassConnector");
        }

        private void diagramDataBindingController1_GenerateItem(object sender, DevExpress.XtraDiagram.DiagramGenerateItemEventArgs e)
        {
            if (((ClassData)e.DataObject).Type == ClassType.Interface)
                e.Item = e.CreateItemFromTemplate("InterfaceShape");
            else e.Item = e.CreateItemFromTemplate("ClassShape");
        }
    }
}
