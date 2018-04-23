Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace DiagramDataControllerBehavior.Data
	Public Class ClassStructureGenerator
		Public Shared Function ClassList() As List(Of ClassData)
			Dim list = New List(Of ClassData)()

			list.Add(New ClassData() With {.ClassName = "IDiagramItem", .Type = ClassType.Interface})

			list.Add(New ClassData() With {.ClassName = "IDiagramContentItem", .Type = ClassType.Interface})

			list.Add(New ClassData() With {.ClassName = "DiagramItem", .Type = ClassType.AbstractClass})

			list.Add(New ClassData() With {.ClassName = "DiagramConnector", .Type = ClassType.Class})

			list.Add(New ClassData() With {.ClassName = "DiagramImage", .Type = ClassType.Class})

			list.Add(New ClassData() With {.ClassName = "BaseDiagramContainer", .Type = ClassType.AbstractClass})

			list.Add(New ClassData() With {.ClassName = "DiagramContentItem", .Type = ClassType.Class})

			list.Add(New ClassData() With {.ClassName = "DiagramShape", .Type = ClassType.Class})

			list.Add(New ClassData() With {.ClassName = "DiagramDecoratorBase", .Type = ClassType.AbstractClass})

			list.Add(New ClassData() With {.ClassName = "DiagramContainerBase", .Type = ClassType.AbstractClass})

			Return list
		End Function

		Public Shared Function ConnectionList() As List(Of ConnectionData)
			Dim cList = New List(Of ConnectionData)()

			cList.Add(New ConnectionData() With {.ConnectedTo = "IDiagramItem", .ConnectedFrom = "DiagramItem"})

			cList.Add(New ConnectionData() With {.ConnectedTo = "IDiagramItem", .ConnectedFrom = "DiagramConnector"})

			cList.Add(New ConnectionData() With {.ConnectedTo = "IDiagramItem", .ConnectedFrom = "DiagramImage"})

			cList.Add(New ConnectionData() With {.ConnectedTo = "IDiagramItem", .ConnectedFrom = "DiagramContentItem"})

			cList.Add(New ConnectionData() With {.ConnectedTo = "IDiagramItem", .ConnectedFrom = "DiagramShape"})

			cList.Add(New ConnectionData() With {.ConnectedTo = "IDiagramItem", .ConnectedFrom = "IDiagramContentItem"})

			cList.Add(New ConnectionData() With {.ConnectedTo = "DiagramItem", .ConnectedFrom = "DiagramConnector"})

			cList.Add(New ConnectionData() With {.ConnectedTo = "DiagramItem", .ConnectedFrom = "DiagramImage"})

			cList.Add(New ConnectionData() With {.ConnectedTo = "DiagramItem", .ConnectedFrom = "DiagramContentItem"})

			cList.Add(New ConnectionData() With {.ConnectedTo = "DiagramItem", .ConnectedFrom = "DiagramShape"})

			cList.Add(New ConnectionData() With {.ConnectedTo = "DiagramItem", .ConnectedFrom = "BaseDiagramContainer"})

			cList.Add(New ConnectionData() With {.ConnectedTo = "DiagramItem", .ConnectedFrom = "DiagramContentItem"})

			cList.Add(New ConnectionData() With {.ConnectedTo = "BaseDiagramContainer", .ConnectedFrom = "DiagramDecoratorBase"})

			cList.Add(New ConnectionData() With {.ConnectedTo = "BaseDiagramContainer", .ConnectedFrom = "DiagramContainerBase"})

			Return cList
		End Function
	End Class
End Namespace
