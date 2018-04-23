namespace DiagramDataControllerBehavior
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.diagramControl1 = new DevExpress.XtraDiagram.DiagramControl();
            this.diagramDataBindingController1 = new DevExpress.XtraDiagram.DiagramDataBindingController(this.components);
            this.diagramContainer1 = new DevExpress.XtraDiagram.DiagramContainer();
            this.diagramShape1 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape2 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramConnector1 = new DevExpress.XtraDiagram.DiagramConnector();
            this.diagramConnector2 = new DevExpress.XtraDiagram.DiagramConnector();
            this.diagramContainer2 = new DevExpress.XtraDiagram.DiagramContainer();
            this.diagramShape3 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape4 = new DevExpress.XtraDiagram.DiagramShape();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1.TemplateDiagram)).BeginInit();
            this.SuspendLayout();
            // 
            // diagramControl1
            // 
            this.diagramControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagramControl1.Location = new System.Drawing.Point(0, 0);
            this.diagramControl1.Name = "diagramControl1";
            this.diagramControl1.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[0]);
            this.diagramControl1.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.diagramControl1.OptionsView.ShowGrid = false;
            this.diagramControl1.OptionsView.ShowPageBreaks = false;
            this.diagramControl1.OptionsView.ShowRulers = false;
            this.diagramControl1.Size = new System.Drawing.Size(1009, 711);
            this.diagramControl1.TabIndex = 0;
            // 
            // diagramDataBindingController1
            // 
            this.diagramDataBindingController1.ConnectorFromMember = "ConnectedFrom";
            this.diagramDataBindingController1.ConnectorsSource = null;
            this.diagramDataBindingController1.ConnectorToMember = "ConnectedTo";
            this.diagramDataBindingController1.Diagram = this.diagramControl1;
            this.diagramDataBindingController1.KeyMember = "ClassName";
            // 
            // 
            // 
            this.diagramDataBindingController1.TemplateDiagram.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramContainer1,
            this.diagramConnector1,
            this.diagramConnector2,
            this.diagramContainer2});
            this.diagramDataBindingController1.TemplateDiagram.Location = new System.Drawing.Point(0, 0);
            this.diagramDataBindingController1.TemplateDiagram.Name = "";
            this.diagramDataBindingController1.TemplateDiagram.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "TemplateDesigner"});
            this.diagramDataBindingController1.TemplateDiagram.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill;
            this.diagramDataBindingController1.TemplateDiagram.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.diagramDataBindingController1.TemplateDiagram.OptionsView.ShowPageBreaks = false;
            this.diagramDataBindingController1.TemplateDiagram.TabIndex = 0;
            this.diagramDataBindingController1.GenerateItem += new System.EventHandler<DevExpress.XtraDiagram.DiagramGenerateItemEventArgs>(this.diagramDataBindingController1_GenerateItem);
            this.diagramDataBindingController1.GenerateConnector += new System.EventHandler<DevExpress.XtraDiagram.DiagramGenerateConnectorEventArgs>(this.diagramDataBindingController1_GenerateConnector);
            // 
            // diagramContainer1
            // 
            this.diagramContainer1.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top)));
            this.diagramContainer1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.diagramContainer1.Appearance.BorderDashPattern = new DevExpress.Diagram.Core.DiagramDoubleCollection(new double[] {
            5D,
            3D});
            this.diagramContainer1.CanAddItems = false;
            this.diagramContainer1.CanCopyWithoutParent = true;
            this.diagramContainer1.ConnectionPoints = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[] {
            new DevExpress.Utils.PointFloat(0.5F, 0F),
            new DevExpress.Utils.PointFloat(1F, 0.5F),
            new DevExpress.Utils.PointFloat(0.5F, 1F),
            new DevExpress.Utils.PointFloat(0F, 0.5F)});
            this.diagramContainer1.DragMode = DevExpress.Diagram.Core.ContainerDragMode.ByAnyPoint;
            this.diagramContainer1.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramShape1,
            this.diagramShape2});
            this.diagramContainer1.ItemsCanAttachConnectorBeginPoint = false;
            this.diagramContainer1.ItemsCanAttachConnectorEndPoint = false;
            this.diagramContainer1.ItemsCanChangeParent = false;
            this.diagramContainer1.ItemsCanCopyWithoutParent = false;
            this.diagramContainer1.ItemsCanDeleteWithoutParent = false;
            this.diagramContainer1.ItemsCanEdit = false;
            this.diagramContainer1.ItemsCanMove = false;
            this.diagramContainer1.ItemsCanResize = false;
            this.diagramContainer1.ItemsCanRotate = false;
            this.diagramContainer1.ItemsCanSelect = false;
            this.diagramContainer1.ItemsCanSnapToOtherItems = false;
            this.diagramContainer1.ItemsCanSnapToThisItem = false;
            this.diagramContainer1.Position = new DevExpress.Utils.PointFloat(150F, 138F);
            this.diagramContainer1.Shape = DevExpress.Diagram.Core.StandardContainers.Alternating;
            this.diagramContainer1.Size = new System.Drawing.SizeF(200F, 79F);
            this.diagramContainer1.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Black;
            this.diagramContainer1.TemplateName = "ClassShape";
            this.diagramContainer1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1;
            // 
            // diagramShape1
            // 
            this.diagramShape1.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top)));
            this.diagramShape1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.diagramShape1.Appearance.BorderSize = 0;
            this.diagramShape1.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.diagramShape1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.diagramShape1.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "ClassName"));
            this.diagramShape1.CanAttachConnectorBeginPoint = false;
            this.diagramShape1.CanAttachConnectorEndPoint = false;
            this.diagramShape1.CanChangeParent = false;
            this.diagramShape1.CanCopyWithoutParent = false;
            this.diagramShape1.CanDeleteWithoutParent = false;
            this.diagramShape1.CanEdit = false;
            this.diagramShape1.CanMove = false;
            this.diagramShape1.CanResize = false;
            this.diagramShape1.CanRotate = false;
            this.diagramShape1.CanSelect = false;
            this.diagramShape1.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Black;
            this.diagramShape1.Position = new DevExpress.Utils.PointFloat(12F, 12F);
            this.diagramShape1.Size = new System.Drawing.SizeF(176F, 25F);
            this.diagramShape1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant2;
            // 
            // diagramShape2
            // 
            this.diagramShape2.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top)));
            this.diagramShape2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.diagramShape2.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.diagramShape2.Appearance.BorderSize = 0;
            this.diagramShape2.Appearance.Font = new System.Drawing.Font("Arial", 8.25F);
            this.diagramShape2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.diagramShape2.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "Type"));
            this.diagramShape2.CanAttachConnectorBeginPoint = false;
            this.diagramShape2.CanAttachConnectorEndPoint = false;
            this.diagramShape2.CanChangeParent = false;
            this.diagramShape2.CanCopyWithoutParent = false;
            this.diagramShape2.CanDeleteWithoutParent = false;
            this.diagramShape2.CanEdit = false;
            this.diagramShape2.CanMove = false;
            this.diagramShape2.CanResize = false;
            this.diagramShape2.CanRotate = false;
            this.diagramShape2.CanSelect = false;
            this.diagramShape2.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Black_3;
            this.diagramShape2.Position = new DevExpress.Utils.PointFloat(12F, 42F);
            this.diagramShape2.Size = new System.Drawing.SizeF(176F, 25F);
            // 
            // diagramConnector1
            // 
            this.diagramConnector1.Appearance.ContentBackground = System.Drawing.Color.White;
            this.diagramConnector1.BeginPoint = new DevExpress.Utils.PointFloat(460F, 170F);
            this.diagramConnector1.CanChangeRoute = false;
            this.diagramConnector1.CanDragBeginPoint = false;
            this.diagramConnector1.CanDragEndPoint = false;
            this.diagramConnector1.EndArrow = DevExpress.Diagram.Core.ArrowDescriptions.ClosedASMEArrow;
            this.diagramConnector1.EndArrowSize = new System.Drawing.SizeF(10F, 10F);
            this.diagramConnector1.EndPoint = new DevExpress.Utils.PointFloat(550F, 260F);
            this.diagramConnector1.Points = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[0]);
            this.diagramConnector1.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Black;
            this.diagramConnector1.TemplateName = "ClassConnector";
            this.diagramConnector1.Type = DevExpress.Diagram.Core.ConnectorType.Straight;
            // 
            // diagramConnector2
            // 
            this.diagramConnector2.Appearance.ContentBackground = System.Drawing.Color.White;
            this.diagramConnector2.BeginPoint = new DevExpress.Utils.PointFloat(483F, 363F);
            this.diagramConnector2.CanChangeRoute = false;
            this.diagramConnector2.CanDragBeginPoint = false;
            this.diagramConnector2.CanDragEndPoint = false;
            this.diagramConnector2.EndArrowSize = new System.Drawing.SizeF(10F, 10F);
            this.diagramConnector2.EndPoint = new DevExpress.Utils.PointFloat(573F, 453F);
            this.diagramConnector2.Points = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[0]);
            this.diagramConnector2.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Black;
            this.diagramConnector2.TemplateName = "InterfaceConnector";
            this.diagramConnector2.Type = DevExpress.Diagram.Core.ConnectorType.Straight;
            // 
            // diagramContainer2
            // 
            this.diagramContainer2.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top)));
            this.diagramContainer2.Appearance.BorderDashPattern = new DevExpress.Diagram.Core.DiagramDoubleCollection(new double[] {
            5D,
            3D});
            this.diagramContainer2.BackgroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Dark_2;
            this.diagramContainer2.CanAddItems = false;
            this.diagramContainer2.CanCopyWithoutParent = true;
            this.diagramContainer2.ConnectionPoints = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[] {
            new DevExpress.Utils.PointFloat(0.5F, 0F),
            new DevExpress.Utils.PointFloat(1F, 0.5F),
            new DevExpress.Utils.PointFloat(0.5F, 1F),
            new DevExpress.Utils.PointFloat(0F, 0.5F)});
            this.diagramContainer2.DragMode = DevExpress.Diagram.Core.ContainerDragMode.ByAnyPoint;
            this.diagramContainer2.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramShape3,
            this.diagramShape4});
            this.diagramContainer2.ItemsCanAttachConnectorBeginPoint = false;
            this.diagramContainer2.ItemsCanAttachConnectorEndPoint = false;
            this.diagramContainer2.ItemsCanChangeParent = false;
            this.diagramContainer2.ItemsCanCopyWithoutParent = false;
            this.diagramContainer2.ItemsCanDeleteWithoutParent = false;
            this.diagramContainer2.ItemsCanEdit = false;
            this.diagramContainer2.ItemsCanMove = false;
            this.diagramContainer2.ItemsCanResize = false;
            this.diagramContainer2.ItemsCanRotate = false;
            this.diagramContainer2.ItemsCanSelect = false;
            this.diagramContainer2.ItemsCanSnapToOtherItems = false;
            this.diagramContainer2.ItemsCanSnapToThisItem = false;
            this.diagramContainer2.Position = new DevExpress.Utils.PointFloat(155F, 305F);
            this.diagramContainer2.Shape = DevExpress.Diagram.Core.StandardContainers.Alternating;
            this.diagramContainer2.Size = new System.Drawing.SizeF(200F, 79F);
            this.diagramContainer2.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Black;
            this.diagramContainer2.TemplateName = "InterfaceShape";
            this.diagramContainer2.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1;
            // 
            // diagramShape3
            // 
            this.diagramShape3.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top)));
            this.diagramShape3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.diagramShape3.Appearance.BorderSize = 0;
            this.diagramShape3.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.diagramShape3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.diagramShape3.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "ClassName"));
            this.diagramShape3.CanAttachConnectorBeginPoint = false;
            this.diagramShape3.CanAttachConnectorEndPoint = false;
            this.diagramShape3.CanChangeParent = false;
            this.diagramShape3.CanCopyWithoutParent = false;
            this.diagramShape3.CanDeleteWithoutParent = false;
            this.diagramShape3.CanEdit = false;
            this.diagramShape3.CanMove = false;
            this.diagramShape3.CanResize = false;
            this.diagramShape3.CanRotate = false;
            this.diagramShape3.CanSelect = false;
            this.diagramShape3.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Black;
            this.diagramShape3.Position = new DevExpress.Utils.PointFloat(12F, 12F);
            this.diagramShape3.Size = new System.Drawing.SizeF(176F, 25F);
            this.diagramShape3.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant2;
            // 
            // diagramShape4
            // 
            this.diagramShape4.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top)));
            this.diagramShape4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.diagramShape4.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.diagramShape4.Appearance.BorderSize = 0;
            this.diagramShape4.Appearance.Font = new System.Drawing.Font("Arial", 8.25F);
            this.diagramShape4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.diagramShape4.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "Type"));
            this.diagramShape4.CanAttachConnectorBeginPoint = false;
            this.diagramShape4.CanAttachConnectorEndPoint = false;
            this.diagramShape4.CanChangeParent = false;
            this.diagramShape4.CanCopyWithoutParent = false;
            this.diagramShape4.CanDeleteWithoutParent = false;
            this.diagramShape4.CanEdit = false;
            this.diagramShape4.CanMove = false;
            this.diagramShape4.CanResize = false;
            this.diagramShape4.CanRotate = false;
            this.diagramShape4.CanSelect = false;
            this.diagramShape4.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Black_3;
            this.diagramShape4.Position = new DevExpress.Utils.PointFloat(12F, 42F);
            this.diagramShape4.Size = new System.Drawing.SizeF(176F, 25F);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 711);
            this.Controls.Add(this.diagramControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1.TemplateDiagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDiagram.DiagramControl diagramControl1;
        private DevExpress.XtraDiagram.DiagramDataBindingController diagramDataBindingController1;
        private DevExpress.XtraDiagram.DiagramContainer diagramContainer1;
        private DevExpress.XtraDiagram.DiagramShape diagramShape1;
        private DevExpress.XtraDiagram.DiagramShape diagramShape2;
        private DevExpress.XtraDiagram.DiagramConnector diagramConnector1;
        private DevExpress.XtraDiagram.DiagramConnector diagramConnector2;
        private DevExpress.XtraDiagram.DiagramContainer diagramContainer2;
        private DevExpress.XtraDiagram.DiagramShape diagramShape3;
        private DevExpress.XtraDiagram.DiagramShape diagramShape4;

    }
}

