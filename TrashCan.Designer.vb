﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrashCan
    Inherits Draggable

    'Control overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Control Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Component Designer
    ' It can be modified using the Component Designer.  Do not modify it
    ' using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        SuspendLayout()
        ' 
        ' TrashCan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        BackgroundImage = My.Resources.Resources.proxy_image
        BackgroundImageLayout = ImageLayout.Stretch
        fixedPosition = True
        Name = "TrashCan"
        ResumeLayout(False)
    End Sub

End Class

