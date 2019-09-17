<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim VectorFileLayer1 As DevExpress.XtraMap.VectorFileLayer = New DevExpress.XtraMap.VectorFileLayer()
        Dim ShapefileLoader1 As DevExpress.XtraMap.ShapefileLoader = New DevExpress.XtraMap.ShapefileLoader()
        Dim VectorFileLayer2 As DevExpress.XtraMap.VectorFileLayer = New DevExpress.XtraMap.VectorFileLayer()
        Dim ShapefileLoader2 As DevExpress.XtraMap.ShapefileLoader = New DevExpress.XtraMap.ShapefileLoader()
        Me.MapControl1 = New DevExpress.XtraMap.MapControl()
        CType(Me.MapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MapControl1
        '
        Me.MapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(60.0R, 5.0R)
        Me.MapControl1.Dock = System.Windows.Forms.DockStyle.Fill
        ShapefileLoader1.FileUri = New System.Uri("D:\Data\Public\Sjøkart\orway-latest-free.shp\gis_osm_landuse_a_free_1.shp", System.UriKind.Absolute)
        VectorFileLayer1.FileLoader = ShapefileLoader1
        ShapefileLoader2.FileUri = New System.Uri("D:\Data\Public\Sjøkart\orway-latest-free.shp\gis_osm_water_a_free_1.shp", System.UriKind.Absolute)
        VectorFileLayer2.FileLoader = ShapefileLoader2
        Me.MapControl1.Layers.Add(VectorFileLayer1)
        Me.MapControl1.Layers.Add(VectorFileLayer2)
        Me.MapControl1.Location = New System.Drawing.Point(0, 0)
        Me.MapControl1.Name = "MapControl1"
        Me.MapControl1.NavigationPanelOptions.ShowMilesScale = False
        Me.MapControl1.Size = New System.Drawing.Size(870, 546)
        Me.MapControl1.TabIndex = 1
        Me.MapControl1.ZoomLevel = 4.0R
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 546)
        Me.Controls.Add(Me.MapControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.MapControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MapControl1 As DevExpress.XtraMap.MapControl
End Class
