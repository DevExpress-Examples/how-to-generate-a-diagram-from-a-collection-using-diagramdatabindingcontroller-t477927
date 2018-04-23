using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramDataControllerBehavior.Data
{
    public class ClassStructureGenerator
    {
        public static List<ClassData> ClassList()
        {
            var list = new List<ClassData>();

            list.Add(new ClassData()
            {
                ClassName = "IDiagramItem",
                Type = ClassType.Interface
            });

            list.Add(new ClassData()
            {
                ClassName = "IDiagramContentItem",
                Type = ClassType.Interface
            });

            list.Add(new ClassData()
            {
                ClassName = "DiagramItem",
                Type = ClassType.AbstractClass
            });

            list.Add(new ClassData()
            {
                ClassName = "DiagramConnector",
                Type = ClassType.Class
            });

            list.Add(new ClassData()
            {
                ClassName = "DiagramImage",
                Type = ClassType.Class
            });

            list.Add(new ClassData()
            {
                ClassName = "BaseDiagramContainer",
                Type = ClassType.AbstractClass
            });

            list.Add(new ClassData()
            {
                ClassName = "DiagramContentItem",
                Type = ClassType.Class
            });

            list.Add(new ClassData()
            {
                ClassName = "DiagramShape",
                Type = ClassType.Class
            });

            list.Add(new ClassData()
            {
                ClassName = "DiagramDecoratorBase",
                Type = ClassType.AbstractClass
            });

            list.Add(new ClassData()
            {
                ClassName = "DiagramContainerBase",
                Type = ClassType.AbstractClass
            });

            return list;
        }

        public static List<ConnectionData> ConnectionList()
        {
            var cList = new List<ConnectionData>();

            cList.Add(new ConnectionData() {
                ConnectedTo = "IDiagramItem",
                ConnectedFrom = "DiagramItem"
            });

            cList.Add(new ConnectionData()
            {
                ConnectedTo = "IDiagramItem",
                ConnectedFrom = "DiagramConnector"
            });

            cList.Add(new ConnectionData()
            {
                ConnectedTo = "IDiagramItem",
                ConnectedFrom = "DiagramImage"
            });

            cList.Add(new ConnectionData()
            {
                ConnectedTo = "IDiagramItem",
                ConnectedFrom = "DiagramContentItem"
            });

            cList.Add(new ConnectionData()
            {
                ConnectedTo = "IDiagramItem",
                ConnectedFrom = "DiagramShape"
            });

            cList.Add(new ConnectionData()
            {
                ConnectedTo = "IDiagramItem",
                ConnectedFrom = "IDiagramContentItem"
            });

            cList.Add(new ConnectionData()
            {
                ConnectedTo = "DiagramItem",
                ConnectedFrom = "DiagramConnector"
            });

            cList.Add(new ConnectionData()
            {
                ConnectedTo = "DiagramItem",
                ConnectedFrom = "DiagramImage"
            });

            cList.Add(new ConnectionData()
            {
                ConnectedTo = "DiagramItem",
                ConnectedFrom = "DiagramContentItem"
            });

            cList.Add(new ConnectionData()
            {
                ConnectedTo = "DiagramItem",
                ConnectedFrom = "DiagramShape"
            });

            cList.Add(new ConnectionData()
            {
                ConnectedTo = "DiagramItem",
                ConnectedFrom = "BaseDiagramContainer"
            });

            cList.Add(new ConnectionData()
            {
                ConnectedTo = "DiagramItem",
                ConnectedFrom = "DiagramContentItem"
            });

            cList.Add(new ConnectionData()
            {
                ConnectedTo = "BaseDiagramContainer",
                ConnectedFrom = "DiagramDecoratorBase"
            });

            cList.Add(new ConnectionData()
            {
                ConnectedTo = "BaseDiagramContainer",
                ConnectedFrom = "DiagramContainerBase"
            });

            return cList;
        }
    }
}
