<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
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
        Me.components = New System.ComponentModel.Container()
        Me.lvDisplay = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.cbMake = New System.Windows.Forms.ComboBox()
        Me.cbYear = New System.Windows.Forms.ComboBox()
        Me.chbNew = New System.Windows.Forms.CheckBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTipCarInventory = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lvDisplay
        '
        Me.lvDisplay.CheckBoxes = True
        Me.lvDisplay.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colID, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvDisplay.FullRowSelect = True
        Me.lvDisplay.Location = New System.Drawing.Point(38, 180)
        Me.lvDisplay.Name = "lvDisplay"
        Me.lvDisplay.Size = New System.Drawing.Size(373, 172)
        Me.lvDisplay.TabIndex = 0
        Me.ToolTipCarInventory.SetToolTip(Me.lvDisplay, "This will Display List")
        Me.lvDisplay.UseCompatibleStateImageBehavior = False
        Me.lvDisplay.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        '
        'colID
        '
        Me.colID.Text = "ID"
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        '
        'lblMake
        '
        Me.lblMake.AutoSize = True
        Me.lblMake.Location = New System.Drawing.Point(35, 18)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(46, 17)
        Me.lblMake.TabIndex = 1
        Me.lblMake.Text = "Make:"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Location = New System.Drawing.Point(35, 56)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(50, 17)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "Model:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(39, 90)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(42, 17)
        Me.lblYear.TabIndex = 3
        Me.lblYear.Text = "Year:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(35, 126)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(44, 17)
        Me.lblPrice.TabIndex = 4
        Me.lblPrice.Text = "Price:"
        '
        'lblNew
        '
        Me.lblNew.AutoSize = True
        Me.lblNew.Location = New System.Drawing.Point(35, 157)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(39, 17)
        Me.lblNew.TabIndex = 5
        Me.lblNew.Text = "New:"
        '
        'cbMake
        '
        Me.cbMake.FormattingEnabled = True
        Me.cbMake.Items.AddRange(New Object() {"hyundai", "Audy", "Honda City", "Jaguar", "Tesla"})
        Me.cbMake.Location = New System.Drawing.Point(101, 16)
        Me.cbMake.Name = "cbMake"
        Me.cbMake.Size = New System.Drawing.Size(121, 24)
        Me.cbMake.TabIndex = 6
        Me.ToolTipCarInventory.SetToolTip(Me.cbMake, "Select from the Options")
        '
        'cbYear
        '
        Me.cbYear.FormattingEnabled = True
        Me.cbYear.Items.AddRange(New Object() {"2014", "2015", "2016", "2017", "2018", ""})
        Me.cbYear.Location = New System.Drawing.Point(101, 83)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(121, 24)
        Me.cbYear.TabIndex = 7
        Me.ToolTipCarInventory.SetToolTip(Me.cbYear, "enter a Year of  the Model")
        '
        'chbNew
        '
        Me.chbNew.AutoSize = True
        Me.chbNew.Location = New System.Drawing.Point(101, 157)
        Me.chbNew.Name = "chbNew"
        Me.chbNew.Size = New System.Drawing.Size(18, 17)
        Me.chbNew.TabIndex = 8
        Me.ToolTipCarInventory.SetToolTip(Me.chbNew, "Click on this, If the Car is new")
        Me.chbNew.UseVisualStyleBackColor = True
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(101, 51)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(121, 22)
        Me.txtModel.TabIndex = 9
        Me.ToolTipCarInventory.SetToolTip(Me.txtModel, "enter  Model number.")
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(101, 121)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(121, 22)
        Me.txtPrice.TabIndex = 10
        Me.ToolTipCarInventory.SetToolTip(Me.txtPrice, "Enter a Price of a car.")
        '
        'lblDisplay
        '
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplay.Location = New System.Drawing.Point(38, 355)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(373, 72)
        Me.lblDisplay.TabIndex = 11
        Me.ToolTipCarInventory.SetToolTip(Me.lblDisplay, "This will show error message")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(174, 444)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 12
        Me.btnEnter.Text = "&Enter"
        Me.ToolTipCarInventory.SetToolTip(Me.btnEnter, "Click This to Display the List")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(255, 444)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "&Reset"
        Me.ToolTipCarInventory.SetToolTip(Me.btnReset, "Click This to Reset Form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(336, 444)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "&Exit"
        Me.ToolTipCarInventory.SetToolTip(Me.btnExit, "Click This to Exit the Application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(441, 479)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.chbNew)
        Me.Controls.Add(Me.cbYear)
        Me.Controls.Add(Me.cbMake)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.Controls.Add(Me.lvDisplay)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvDisplay As ListView
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents lblMake As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblNew As Label
    Friend WithEvents cbMake As ComboBox
    Friend WithEvents cbYear As ComboBox
    Friend WithEvents chbNew As CheckBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblDisplay As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button

    Private Sub cbMake_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMake.SelectedIndexChanged

    End Sub

    Private Sub lvDisplay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDisplay.SelectedIndexChanged

    End Sub

    Private Sub frmCarInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents ToolTipCarInventory As ToolTip
End Class
