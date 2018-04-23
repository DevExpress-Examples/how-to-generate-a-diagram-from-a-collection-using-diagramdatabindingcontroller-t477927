Namespace DiagramDataControllerBehavior
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.diagramControl1 = New DevExpress.XtraDiagram.DiagramControl()
			Me.diagramDataBindingController1 = New DevExpress.XtraDiagram.DiagramDataBindingController(Me.components)
			Me.diagramContainer1 = New DevExpress.XtraDiagram.DiagramContainer()
			Me.diagramShape1 = New DevExpress.XtraDiagram.DiagramShape()
			Me.diagramShape2 = New DevExpress.XtraDiagram.DiagramShape()
			Me.diagramConnector1 = New DevExpress.XtraDiagram.DiagramConnector()
			Me.diagramConnector2 = New DevExpress.XtraDiagram.DiagramConnector()
			Me.diagramContainer2 = New DevExpress.XtraDiagram.DiagramContainer()
			Me.diagramShape3 = New DevExpress.XtraDiagram.DiagramShape()
			Me.diagramShape4 = New DevExpress.XtraDiagram.DiagramShape()
			DirectCast(Me.diagramControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.diagramDataBindingController1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.diagramDataBindingController1.TemplateDiagram, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' diagramControl1
			' 
			Me.diagramControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.diagramControl1.Location = New System.Drawing.Point(0, 0)
			Me.diagramControl1.Name = "diagramControl1"
			Me.diagramControl1.OptionsBehavior.SelectedStencils = New DevExpress.Diagram.Core.StencilCollection(New String(){})
			Me.diagramControl1.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter
			Me.diagramControl1.OptionsView.ShowGrid = False
			Me.diagramControl1.OptionsView.ShowPageBreaks = False
			Me.diagramControl1.OptionsView.ShowRulers = False
			Me.diagramControl1.Size = New System.Drawing.Size(1009, 711)
			Me.diagramControl1.TabIndex = 0
			' 
			' diagramDataBindingController1
			' 
			Me.diagramDataBindingController1.ConnectorFromMember = "ConnectedFrom"
			Me.diagramDataBindingController1.ConnectorsSource = Nothing
			Me.diagramDataBindingController1.ConnectorToMember = "ConnectedTo"
			Me.diagramDataBindingController1.Diagram = Me.diagramControl1
			Me.diagramDataBindingController1.KeyMember = "ClassName"
			' 
			' 
			' 
			Me.diagramDataBindingController1.TemplateDiagram.Items.AddRange(New DevExpress.XtraDiagram.DiagramItem() { Me.diagramContainer1, Me.diagramConnector1, Me.diagramConnector2, Me.diagramContainer2})
			Me.diagramDataBindingController1.TemplateDiagram.Location = New System.Drawing.Point(0, 0)
			Me.diagramDataBindingController1.TemplateDiagram.Name = ""
			Me.diagramDataBindingController1.TemplateDiagram.OptionsBehavior.SelectedStencils = New DevExpress.Diagram.Core.StencilCollection(New String() { "TemplateDesigner"})
			Me.diagramDataBindingController1.TemplateDiagram.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill
			Me.diagramDataBindingController1.TemplateDiagram.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter
			Me.diagramDataBindingController1.TemplateDiagram.OptionsView.ShowPageBreaks = False
			Me.diagramDataBindingController1.TemplateDiagram.TabIndex = 0
'			Me.diagramDataBindingController1.GenerateItem += New System.EventHandler(Of DevExpress.XtraDiagram.DiagramGenerateItemEventArgs)(Me.diagramDataBindingController1_GenerateItem)
'			Me.diagramDataBindingController1.GenerateConnector += New System.EventHandler(Of DevExpress.XtraDiagram.DiagramGenerateConnectorEventArgs)(Me.diagramDataBindingController1_GenerateConnector)
			' 
			' diagramContainer1
			' 
			Me.diagramContainer1.Anchors = (CType((DevExpress.Diagram.Core.Sides.Left Or DevExpress.Diagram.Core.Sides.Top), DevExpress.Diagram.Core.Sides))
			Me.diagramContainer1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(199)))), (CInt((CByte(221)))), (CInt((CByte(240)))))
			Me.diagramContainer1.Appearance.BorderDashPattern = New DevExpress.Diagram.Core.DiagramDoubleCollection(New Double() { 5R, 3R})
			Me.diagramContainer1.CanAddItems = False
            Me.diagramContainer1.CanCopyWithoutParent = True
            Me.diagramContainer1.DragMode = DevExpress.Diagram.Core.ContainerDragMode.ByAnyPoint
			Me.diagramContainer1.ConnectionPoints = New DevExpress.XtraDiagram.PointCollection(New DevExpress.Utils.PointFloat() {
				New DevExpress.Utils.PointFloat(0.5F, 0F),
				New DevExpress.Utils.PointFloat(1F, 0.5F),
				New DevExpress.Utils.PointFloat(0.5F, 1F),
				New DevExpress.Utils.PointFloat(0F, 0.5F)
			})
			Me.diagramContainer1.Items.AddRange(New DevExpress.XtraDiagram.DiagramItem() { Me.diagramShape1, Me.diagramShape2})
			Me.diagramContainer1.ItemsCanAttachConnectorBeginPoint = False
			Me.diagramContainer1.ItemsCanAttachConnectorEndPoint = False
			Me.diagramContainer1.ItemsCanChangeParent = False
			Me.diagramContainer1.ItemsCanCopyWithoutParent = False
			Me.diagramContainer1.ItemsCanDeleteWithoutParent = False
			Me.diagramContainer1.ItemsCanEdit = False
			Me.diagramContainer1.ItemsCanMove = False
			Me.diagramContainer1.ItemsCanResize = False
			Me.diagramContainer1.ItemsCanRotate = False
			Me.diagramContainer1.ItemsCanSelect = False
			Me.diagramContainer1.ItemsCanSnapToOtherItems = False
			Me.diagramContainer1.ItemsCanSnapToThisItem = False
			Me.diagramContainer1.Position = New DevExpress.Utils.PointFloat(150F, 138F)
			Me.diagramContainer1.Shape = DevExpress.Diagram.Core.StandardContainers.Alternating
			Me.diagramContainer1.Size = New System.Drawing.SizeF(200F, 79F)
			Me.diagramContainer1.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Black
			Me.diagramContainer1.TemplateName = "ClassShape"
			Me.diagramContainer1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1
			' 
			' diagramShape1
			' 
			Me.diagramShape1.Anchors = (CType((DevExpress.Diagram.Core.Sides.Left Or DevExpress.Diagram.Core.Sides.Top), DevExpress.Diagram.Core.Sides))
			Me.diagramShape1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.diagramShape1.Appearance.BorderSize = 0
			Me.diagramShape1.Appearance.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.diagramShape1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.diagramShape1.Bindings.Add(New DevExpress.Diagram.Core.DiagramBinding("Content", "ClassName"))
			Me.diagramShape1.CanAttachConnectorBeginPoint = False
			Me.diagramShape1.CanAttachConnectorEndPoint = False
			Me.diagramShape1.CanChangeParent = False
			Me.diagramShape1.CanCopyWithoutParent = False
			Me.diagramShape1.CanDeleteWithoutParent = False
			Me.diagramShape1.CanEdit = False
			Me.diagramShape1.CanMove = False
			Me.diagramShape1.CanResize = False
			Me.diagramShape1.CanRotate = False
			Me.diagramShape1.CanSelect = False
			Me.diagramShape1.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Black
			Me.diagramShape1.Position = New DevExpress.Utils.PointFloat(12F, 12F)
			Me.diagramShape1.Size = New System.Drawing.SizeF(176F, 25F)
			Me.diagramShape1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant2
			' 
			' diagramShape2
			' 
			Me.diagramShape2.Anchors = (CType((DevExpress.Diagram.Core.Sides.Left Or DevExpress.Diagram.Core.Sides.Top), DevExpress.Diagram.Core.Sides))
			Me.diagramShape2.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.diagramShape2.Appearance.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.diagramShape2.Appearance.BorderSize = 0
			Me.diagramShape2.Appearance.Font = New System.Drawing.Font("Arial", 8.25F)
			Me.diagramShape2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.diagramShape2.Bindings.Add(New DevExpress.Diagram.Core.DiagramBinding("Content", "Type"))
			Me.diagramShape2.CanAttachConnectorBeginPoint = False
			Me.diagramShape2.CanAttachConnectorEndPoint = False
			Me.diagramShape2.CanChangeParent = False
			Me.diagramShape2.CanCopyWithoutParent = False
			Me.diagramShape2.CanDeleteWithoutParent = False
			Me.diagramShape2.CanEdit = False
			Me.diagramShape2.CanMove = False
			Me.diagramShape2.CanResize = False
			Me.diagramShape2.CanRotate = False
			Me.diagramShape2.CanSelect = False
			Me.diagramShape2.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Black_3
			Me.diagramShape2.Position = New DevExpress.Utils.PointFloat(12F, 42F)
			Me.diagramShape2.Size = New System.Drawing.SizeF(176F, 25F)
			' 
			' diagramConnector1
			' 
			Me.diagramConnector1.Appearance.ContentBackground = System.Drawing.Color.White
			Me.diagramConnector1.BeginPoint = New DevExpress.Utils.PointFloat(460F, 170F)
			Me.diagramConnector1.CanChangeRoute = False
			Me.diagramConnector1.CanDragBeginPoint = False
			Me.diagramConnector1.CanDragEndPoint = False
			Me.diagramConnector1.EndArrow = DevExpress.Diagram.Core.ArrowDescriptions.ClosedASMEArrow
			Me.diagramConnector1.EndArrowSize = New System.Drawing.SizeF(10F, 10F)
			Me.diagramConnector1.EndPoint = New DevExpress.Utils.PointFloat(550F, 260F)
			Me.diagramConnector1.Points = New DevExpress.XtraDiagram.PointCollection(New DevExpress.Utils.PointFloat(){})
			Me.diagramConnector1.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Black
			Me.diagramConnector1.TemplateName = "ClassConnector"
			Me.diagramConnector1.Type = DevExpress.Diagram.Core.ConnectorType.Straight
			' 
			' diagramConnector2
			' 
			Me.diagramConnector2.Appearance.ContentBackground = System.Drawing.Color.White
			Me.diagramConnector2.BeginPoint = New DevExpress.Utils.PointFloat(483F, 363F)
			Me.diagramConnector2.CanChangeRoute = False
			Me.diagramConnector2.CanDragBeginPoint = False
			Me.diagramConnector2.CanDragEndPoint = False
			Me.diagramConnector2.EndArrowSize = New System.Drawing.SizeF(10F, 10F)
			Me.diagramConnector2.EndPoint = New DevExpress.Utils.PointFloat(573F, 453F)
			Me.diagramConnector2.Points = New DevExpress.XtraDiagram.PointCollection(New DevExpress.Utils.PointFloat(){})
			Me.diagramConnector2.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Black
			Me.diagramConnector2.TemplateName = "InterfaceConnector"
			Me.diagramConnector2.Type = DevExpress.Diagram.Core.ConnectorType.Straight
			' 
			' diagramContainer2
			' 
			Me.diagramContainer2.Anchors = (CType((DevExpress.Diagram.Core.Sides.Left Or DevExpress.Diagram.Core.Sides.Top), DevExpress.Diagram.Core.Sides))
			Me.diagramContainer2.Appearance.BorderDashPattern = New DevExpress.Diagram.Core.DiagramDoubleCollection(New Double() { 5R, 3R})
			Me.diagramContainer2.BackgroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Dark_2
			Me.diagramContainer2.CanAddItems = False
            Me.diagramContainer2.CanCopyWithoutParent = True
            Me.diagramContainer2.DragMode = DevExpress.Diagram.Core.ContainerDragMode.ByAnyPoint
			Me.diagramContainer2.ConnectionPoints = New DevExpress.XtraDiagram.PointCollection(New DevExpress.Utils.PointFloat() {
				New DevExpress.Utils.PointFloat(0.5F, 0F),
				New DevExpress.Utils.PointFloat(1F, 0.5F),
				New DevExpress.Utils.PointFloat(0.5F, 1F),
				New DevExpress.Utils.PointFloat(0F, 0.5F)
			})
			Me.diagramContainer2.Items.AddRange(New DevExpress.XtraDiagram.DiagramItem() { Me.diagramShape3, Me.diagramShape4})
			Me.diagramContainer2.ItemsCanAttachConnectorBeginPoint = False
			Me.diagramContainer2.ItemsCanAttachConnectorEndPoint = False
			Me.diagramContainer2.ItemsCanChangeParent = False
			Me.diagramContainer2.ItemsCanCopyWithoutParent = False
			Me.diagramContainer2.ItemsCanDeleteWithoutParent = False
			Me.diagramContainer2.ItemsCanEdit = False
			Me.diagramContainer2.ItemsCanMove = False
			Me.diagramContainer2.ItemsCanResize = False
			Me.diagramContainer2.ItemsCanRotate = False
			Me.diagramContainer2.ItemsCanSelect = False
			Me.diagramContainer2.ItemsCanSnapToOtherItems = False
			Me.diagramContainer2.ItemsCanSnapToThisItem = False
			Me.diagramContainer2.Position = New DevExpress.Utils.PointFloat(155F, 305F)
			Me.diagramContainer2.Shape = DevExpress.Diagram.Core.StandardContainers.Alternating
			Me.diagramContainer2.Size = New System.Drawing.SizeF(200F, 79F)
			Me.diagramContainer2.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Black
			Me.diagramContainer2.TemplateName = "InterfaceShape"
			Me.diagramContainer2.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1
			' 
			' diagramShape3
			' 
			Me.diagramShape3.Anchors = (CType((DevExpress.Diagram.Core.Sides.Left Or DevExpress.Diagram.Core.Sides.Top), DevExpress.Diagram.Core.Sides))
			Me.diagramShape3.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.diagramShape3.Appearance.BorderSize = 0
			Me.diagramShape3.Appearance.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.diagramShape3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.diagramShape3.Bindings.Add(New DevExpress.Diagram.Core.DiagramBinding("Content", "ClassName"))
			Me.diagramShape3.CanAttachConnectorBeginPoint = False
			Me.diagramShape3.CanAttachConnectorEndPoint = False
			Me.diagramShape3.CanChangeParent = False
			Me.diagramShape3.CanCopyWithoutParent = False
			Me.diagramShape3.CanDeleteWithoutParent = False
			Me.diagramShape3.CanEdit = False
			Me.diagramShape3.CanMove = False
			Me.diagramShape3.CanResize = False
			Me.diagramShape3.CanRotate = False
			Me.diagramShape3.CanSelect = False
			Me.diagramShape3.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Black
			Me.diagramShape3.Position = New DevExpress.Utils.PointFloat(12F, 12F)
			Me.diagramShape3.Size = New System.Drawing.SizeF(176F, 25F)
			Me.diagramShape3.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant2
			' 
			' diagramShape4
			' 
			Me.diagramShape4.Anchors = (CType((DevExpress.Diagram.Core.Sides.Left Or DevExpress.Diagram.Core.Sides.Top), DevExpress.Diagram.Core.Sides))
			Me.diagramShape4.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.diagramShape4.Appearance.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.diagramShape4.Appearance.BorderSize = 0
			Me.diagramShape4.Appearance.Font = New System.Drawing.Font("Arial", 8.25F)
			Me.diagramShape4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.diagramShape4.Bindings.Add(New DevExpress.Diagram.Core.DiagramBinding("Content", "Type"))
			Me.diagramShape4.CanAttachConnectorBeginPoint = False
			Me.diagramShape4.CanAttachConnectorEndPoint = False
			Me.diagramShape4.CanChangeParent = False
			Me.diagramShape4.CanCopyWithoutParent = False
			Me.diagramShape4.CanDeleteWithoutParent = False
			Me.diagramShape4.CanEdit = False
			Me.diagramShape4.CanMove = False
			Me.diagramShape4.CanResize = False
			Me.diagramShape4.CanRotate = False
			Me.diagramShape4.CanSelect = False
			Me.diagramShape4.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Black_3
			Me.diagramShape4.Position = New DevExpress.Utils.PointFloat(12F, 42F)
			Me.diagramShape4.Size = New System.Drawing.SizeF(176F, 25F)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1009, 711)
			Me.Controls.Add(Me.diagramControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			DirectCast(Me.diagramControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.diagramDataBindingController1.TemplateDiagram, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.diagramDataBindingController1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private diagramControl1 As DevExpress.XtraDiagram.DiagramControl
		Private WithEvents diagramDataBindingController1 As DevExpress.XtraDiagram.DiagramDataBindingController
		Private diagramContainer1 As DevExpress.XtraDiagram.DiagramContainer
		Private diagramShape1 As DevExpress.XtraDiagram.DiagramShape
		Private diagramShape2 As DevExpress.XtraDiagram.DiagramShape
		Private diagramConnector1 As DevExpress.XtraDiagram.DiagramConnector
		Private diagramConnector2 As DevExpress.XtraDiagram.DiagramConnector
		Private diagramContainer2 As DevExpress.XtraDiagram.DiagramContainer
		Private diagramShape3 As DevExpress.XtraDiagram.DiagramShape
		Private diagramShape4 As DevExpress.XtraDiagram.DiagramShape

	End Class
End Namespace

