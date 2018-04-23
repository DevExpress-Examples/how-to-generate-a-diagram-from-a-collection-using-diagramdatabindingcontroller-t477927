Imports DiagramDataControllerBehavior.Data
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace DiagramDataControllerBehavior
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
			diagramDataBindingController1.DataSource = ClassStructureGenerator.ClassList()
			diagramDataBindingController1.ConnectorsSource = ClassStructureGenerator.ConnectionList()

		End Sub

		Private Sub diagramDataBindingController1_GenerateConnector(ByVal sender As Object, ByVal e As DevExpress.XtraDiagram.DiagramGenerateConnectorEventArgs) Handles diagramDataBindingController1.GenerateConnector
			If CType(e.From, ClassData).Type = ClassType.Interface OrElse CType(e.To, ClassData).Type = ClassType.Interface Then
				e.Connector = e.CreateConnectorFromTemplate("InterfaceConnector")
			Else
				e.Connector = e.CreateConnectorFromTemplate("ClassConnector")
			End If
		End Sub

		Private Sub diagramDataBindingController1_GenerateItem(ByVal sender As Object, ByVal e As DevExpress.XtraDiagram.DiagramGenerateItemEventArgs) Handles diagramDataBindingController1.GenerateItem
			If CType(e.DataObject, ClassData).Type = ClassType.Interface Then
				e.Item = e.CreateItemFromTemplate("InterfaceShape")
			Else
				e.Item = e.CreateItemFromTemplate("ClassShape")
			End If
		End Sub
	End Class
End Namespace
