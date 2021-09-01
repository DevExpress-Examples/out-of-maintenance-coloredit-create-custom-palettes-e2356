﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Editors

Namespace DXEditors_ColorEdit
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
			' Removes the 'Standard Colors' palette.
			colorEdit1.Palettes.Remove(colorEdit1.Palettes("Standard Colors"))
			' Adds a custom gradient palette.
			colorEdit1.Palettes.Add(CustomPalette.CreateGradientPalette("Apex Colors", PredefinedColorCollections.Apex))
			' Adds a new palette with three custom RGB colors.
			colorEdit1.Palettes.Add(New CustomPalette("Custom RGB Colors", New List(Of Color)() From {Color.FromRgb(150, 18, 30), Color.FromRgb(20, 40, 20), Color.FromRgb(88, 73, 29)}))
		End Sub
	End Class
End Namespace
