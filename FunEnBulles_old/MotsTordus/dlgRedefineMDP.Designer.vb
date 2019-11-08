<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgRedefineMDP
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.lblNewMDPVerif = New System.Windows.Forms.Label()
        Me.txtNewMDPVerif = New System.Windows.Forms.TextBox()
        Me.lblNewMDP = New System.Windows.Forms.Label()
        Me.txtNewMDP = New System.Windows.Forms.TextBox()
        Me.lblMDPChangeConsigne = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 226)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Annuler"
        '
        'lblNewMDPVerif
        '
        Me.lblNewMDPVerif.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewMDPVerif.Location = New System.Drawing.Point(20, 175)
        Me.lblNewMDPVerif.Name = "lblNewMDPVerif"
        Me.lblNewMDPVerif.Size = New System.Drawing.Size(241, 24)
        Me.lblNewMDPVerif.TabIndex = 38
        Me.lblNewMDPVerif.Text = "Verification du mot de passe : "
        Me.lblNewMDPVerif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNewMDPVerif
        '
        Me.txtNewMDPVerif.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewMDPVerif.Location = New System.Drawing.Point(262, 177)
        Me.txtNewMDPVerif.Name = "txtNewMDPVerif"
        Me.txtNewMDPVerif.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtNewMDPVerif.Size = New System.Drawing.Size(122, 25)
        Me.txtNewMDPVerif.TabIndex = 37
        '
        'lblNewMDP
        '
        Me.lblNewMDP.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewMDP.Location = New System.Drawing.Point(68, 126)
        Me.lblNewMDP.Name = "lblNewMDP"
        Me.lblNewMDP.Size = New System.Drawing.Size(193, 22)
        Me.lblNewMDP.TabIndex = 36
        Me.lblNewMDP.Text = "Nouveau mot de passe : "
        Me.lblNewMDP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNewMDP
        '
        Me.txtNewMDP.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewMDP.Location = New System.Drawing.Point(262, 127)
        Me.txtNewMDP.Name = "txtNewMDP"
        Me.txtNewMDP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtNewMDP.Size = New System.Drawing.Size(122, 25)
        Me.txtNewMDP.TabIndex = 35
        '
        'lblMDPChangeConsigne
        '
        Me.lblMDPChangeConsigne.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.lblMDPChangeConsigne.Location = New System.Drawing.Point(35, 56)
        Me.lblMDPChangeConsigne.Name = "lblMDPChangeConsigne"
        Me.lblMDPChangeConsigne.Size = New System.Drawing.Size(380, 58)
        Me.lblMDPChangeConsigne.TabIndex = 34
        Me.lblMDPChangeConsigne.Text = "Votre mot de passe est actuellement celui par defaut, nous vous conseillons de le" & _
    " changer : "
        '
        'dlgRedefineMDP
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(435, 267)
        Me.Controls.Add(Me.lblNewMDPVerif)
        Me.Controls.Add(Me.txtNewMDPVerif)
        Me.Controls.Add(Me.lblNewMDP)
        Me.Controls.Add(Me.txtNewMDP)
        Me.Controls.Add(Me.lblMDPChangeConsigne)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRedefineMDP"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "dlgRedefineMDP"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents lblNewMDPVerif As System.Windows.Forms.Label
    Friend WithEvents txtNewMDPVerif As System.Windows.Forms.TextBox
    Friend WithEvents lblNewMDP As System.Windows.Forms.Label
    Friend WithEvents txtNewMDP As System.Windows.Forms.TextBox
    Friend WithEvents lblMDPChangeConsigne As System.Windows.Forms.Label

End Class
