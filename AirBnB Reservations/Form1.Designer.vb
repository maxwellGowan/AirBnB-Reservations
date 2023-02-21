<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAirBnB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAirBnB))
        Me.picAirBnB = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblNightlyCost = New System.Windows.Forms.Label()
        Me.lblNumberNights = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblCalcCost = New System.Windows.Forms.Label()
        Me.btnDisplayCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtNights = New System.Windows.Forms.TextBox()
        CType(Me.picAirBnB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picAirBnB
        '
        Me.picAirBnB.Image = CType(resources.GetObject("picAirBnB.Image"), System.Drawing.Image)
        Me.picAirBnB.Location = New System.Drawing.Point(9, 7)
        Me.picAirBnB.Name = "picAirBnB"
        Me.picAirBnB.Size = New System.Drawing.Size(395, 420)
        Me.picAirBnB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAirBnB.TabIndex = 0
        Me.picAirBnB.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Cooper Black", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHeader.Location = New System.Drawing.Point(501, 22)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(253, 34)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Orlando AirBnB"
        '
        'lblNightlyCost
        '
        Me.lblNightlyCost.AutoSize = True
        Me.lblNightlyCost.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNightlyCost.Location = New System.Drawing.Point(536, 56)
        Me.lblNightlyCost.Name = "lblNightlyCost"
        Me.lblNightlyCost.Size = New System.Drawing.Size(187, 19)
        Me.lblNightlyCost.TabIndex = 2
        Me.lblNightlyCost.Text = "Only $79.00 per night"
        '
        'lblNumberNights
        '
        Me.lblNumberNights.AutoSize = True
        Me.lblNumberNights.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberNights.Location = New System.Drawing.Point(433, 145)
        Me.lblNumberNights.Name = "lblNumberNights"
        Me.lblNumberNights.Size = New System.Drawing.Size(136, 18)
        Me.lblNumberNights.TabIndex = 3
        Me.lblNumberNights.Text = "Number of Nights:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(433, 221)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(97, 18)
        Me.lblCost.TabIndex = 4
        Me.lblCost.Text = "Cost of Stay:"
        '
        'lblCalcCost
        '
        Me.lblCalcCost.AutoSize = True
        Me.lblCalcCost.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalcCost.Location = New System.Drawing.Point(606, 226)
        Me.lblCalcCost.Name = "lblCalcCost"
        Me.lblCalcCost.Size = New System.Drawing.Size(0, 20)
        Me.lblCalcCost.TabIndex = 5
        '
        'btnDisplayCost
        '
        Me.btnDisplayCost.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayCost.Location = New System.Drawing.Point(442, 390)
        Me.btnDisplayCost.Name = "btnDisplayCost"
        Me.btnDisplayCost.Size = New System.Drawing.Size(88, 23)
        Me.btnDisplayCost.TabIndex = 6
        Me.btnDisplayCost.Text = "Display Cost"
        Me.btnDisplayCost.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(563, 390)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(679, 390)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtNights
        '
        Me.txtNights.Location = New System.Drawing.Point(610, 145)
        Me.txtNights.Name = "txtNights"
        Me.txtNights.Size = New System.Drawing.Size(44, 20)
        Me.txtNights.TabIndex = 9
        '
        'frmAirBnB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Olive
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtNights)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayCost)
        Me.Controls.Add(Me.lblCalcCost)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblNumberNights)
        Me.Controls.Add(Me.lblNightlyCost)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.picAirBnB)
        Me.Name = "frmAirBnB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AirBnB Reservations"
        CType(Me.picAirBnB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picAirBnB As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblNightlyCost As Label
    Friend WithEvents lblNumberNights As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents lblCalcCost As Label
    Friend WithEvents btnDisplayCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtNights As TextBox
End Class
