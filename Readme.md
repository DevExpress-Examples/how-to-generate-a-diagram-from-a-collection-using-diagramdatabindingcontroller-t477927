<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128585387/16.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T477927)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [ClassData.cs](./CS/DiagramDataControllerBehavior/Data/ClassData.cs) (VB: [ClassData.vb](./VB/DiagramDataControllerBehavior/Data/ClassData.vb))
* [ClassStructureGenerator.cs](./CS/DiagramDataControllerBehavior/Data/ClassStructureGenerator.cs) (VB: [ClassStructureGenerator.vb](./VB/DiagramDataControllerBehavior/Data/ClassStructureGenerator.vb))
* [Form1.cs](./CS/DiagramDataControllerBehavior/Form1.cs) (VB: [Form1.vb](./VB/DiagramDataControllerBehavior/Form1.vb))
* [Program.cs](./CS/DiagramDataControllerBehavior/Program.cs) (VB: [Program.vb](./VB/DiagramDataControllerBehavior/Program.vb))
<!-- default file list end -->
# How to generate a diagram from a collection using DiagramDataBindingController


<p>This example demonstrates how to generate a diagram from a certain source/collection using <a href="https://documentation.devexpress.com/WindowsForms/clsDevExpressXtraDiagramDiagramDataBindingControllertopic.aspx">DiagramDataBindingController</a>. To provide <a href="https://documentation.devexpress.com/WindowsForms/clsDevExpressXtraDiagramDiagramDataBindingControllertopic.aspx">DiagramDataBindingController</a> with the required source, use the <a href="https://documentation.devexpress.com/WindowsForms/DevExpressXtraDiagramDiagramDataBindingControllerBase_DataSourcetopic.aspx">DataSource</a> property. To build and display relationships between diagram shapes, use the <a href="https://documentation.devexpress.com/WindowsForms/DevExpressXtraDiagramDiagramDataBindingControllerBase_KeyMembertopic.aspx">KeyMember</a> property and the <a href="https://documentation.devexpress.com/WindowsForms/DevExpressXtraDiagramDiagramDataBindingController_ConnectorsSourcetopic.aspx">ConnectorsSource</a> collection. The <a href="https://documentation.devexpress.com/WindowsForms/DevExpressXtraDiagramDiagramDataBindingController_ConnectorFromMembertopic.aspx">ConnectorFromMember</a> and <a href="https://documentation.devexpress.com/WindowsForms/DevExpressXtraDiagramDiagramDataBindingController_ConnectorToMembertopic.aspx">ConnectorToMember</a> properties specify data fields that identify items to use as a connector's begin and end items.</p>
<p>Each "template" item created using the <a href="https://documentation.devexpress.com/WindowsForms/CustomDocument117683.aspx">Item Template Designer</a> has the <a href="https://documentation.devexpress.com/WindowsForms/DevExpressXtraDiagramDiagramItem_TemplateNametopic.aspx">TemplateName</a> set to a certain unique value. In the <a href="https://documentation.devexpress.com/WindowsForms/DevExpressXtraDiagramDiagramDataBindingControllerBase_GenerateConnectortopic.aspx">GenerateConnector</a> and <a href="https://documentation.devexpress.com/WindowsForms/DevExpressXtraDiagramDiagramDataBindingControllerBase_GenerateItemtopic.aspx">GenerateItem</a> event handlers, this property value is used to create a required shape/connector based on a certain condition.<br>See also: <a href="https://documentation.devexpress.com/WPF/CustomDocument117585.aspx">Data Binding Functionality</a>.</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-generate-a-diagram-from-a-collection-using-diagramdatabindingcontroller-t477927&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-generate-a-diagram-from-a-collection-using-diagramdatabindingcontroller-t477927&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
