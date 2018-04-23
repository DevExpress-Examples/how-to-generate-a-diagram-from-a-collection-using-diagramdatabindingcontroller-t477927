Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace DiagramDataControllerBehavior.Data
	Public Class ClassData
		Public Property ClassName() As String
		Public Property Type() As ClassType
	End Class
	Public Enum ClassType
		[Class]
		[Interface]
		AbstractClass
	End Enum

	Public Class ConnectionData
		Public Property ConnectedFrom() As Object
		Public Property ConnectedTo() As Object
	End Class
End Namespace
