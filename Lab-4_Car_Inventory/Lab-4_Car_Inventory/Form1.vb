

Option Strict On
''' <summary>
''' Name:  Ritu Patel
''' Date:  july 11,2019
''' Description: The purpose of this lab is to understand the class.
''' </summary>

Public Class frmCarInventory


    Private carInventory As New SortedList
    Private currentCustomerIdentificationNumber As String = String.Empty ' 
    Private editMode As Boolean = False                                 '


    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim cars As car    ' declare a car class
        Dim carItem As ListViewItem    ' declare a ListViewItem class


        If IsValidInput() = True Then


            editMode = True

            ' 
            lblDisplay.Text = "It worked!"


            If currentCustomerIdentificationNumber.Trim.Length = 0 Then


                cars = New car(cbMake.Text, txtModel.Text, cbYear.Text, txtPrice.Text, chbNew.Checked)


                carInventory.Add(cars.IdentificationNumber.ToString(), cars)

            Else

                cars = CType(carInventory.Item(currentCustomerIdentificationNumber), car)


                cars.Make = cbMake.Text
                cars.Price = txtPrice.Text
                cars.Model = txtModel.Text
                cars.Year = cbYear.Text

                cars.carNew = chbNew.Checked

            End If

            lvDisplay.Items.Clear()

            For Each carEntry As DictionaryEntry In carInventory

                carItem = New ListViewItem()

                cars = CType(carEntry.Value, car)

                carItem.SubItems.Add(cars.IdentificationNumber.ToString())
                carItem.Checked = cars.carNew
                carItem.SubItems.Add(cars.Make)
                carItem.SubItems.Add(cars.Model)
                carItem.SubItems.Add(cars.Year)
                carItem.SubItems.Add(cars.Price)


                lvDisplay.Items.Add(carItem)

            Next carEntry


            ' clear the controls
            Reset()

            ' set the edit flag to false
            editMode = False

        End If

    End Sub


    Private Sub Reset()


        txtPrice.Text = String.Empty
        txtModel.Text = String.Empty
        chbNew.Checked = False
        cbMake.SelectedIndex = -1
        cbYear.SelectedIndex = -1
        lblDisplay.Text = String.Empty

        currentCustomerIdentificationNumber = String.Empty

    End Sub

    Private Function IsValidInput() As Boolean

        Dim returnValue As Boolean = True
        Dim outputMessage As String = String.Empty


        If cbMake.SelectedIndex = -1 Then


            outputMessage += "Please select the manufacturing model of the car." & vbCrLf

        End If
        If cbYear.SelectedIndex = -1 Then


            outputMessage += "Please select year of the car." & vbCrLf


            returnValue = False

            End If


        If txtModel.Text.Trim.Length = 0 Then


            outputMessage += "Please enter the Model of car." & vbCrLf


            returnValue = False

        End If


        Dim enterValue As Double

        If Not Double.TryParse(txtPrice.Text, enterValue) Then
            outputMessage += "Please enter the car's price in numeric." & vbCrLf

            returnValue = False

        End If

        If enterValue < 0 Then
            outputMessage += "Please enter the car's price greater than 0." & vbCrLf

            returnValue = False
        End If


        If returnValue = False Then


            lblDisplay.Text = "ERRORS" & vbCrLf & outputMessage

        End If


        Return returnValue

    End Function


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click


        Reset()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click


        Me.Close()

    End Sub


    Private Sub lvwCustomers_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvDisplay.ItemCheck


        If editMode = False Then


            e.NewValue = e.CurrentValue

        End If

    End Sub


    Private Sub lvwCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDisplay.SelectedIndexChanged


        Const identificationSubItemIndex As Integer = 1


        currentCustomerIdentificationNumber = lvDisplay.Items(lvDisplay.FocusedItem.Index).SubItems(identificationSubItemIndex).Text


        Dim Car As car = CType(carInventory.Item(currentCustomerIdentificationNumber), car)


        txtModel.Text = Car.Model
        txtPrice.Text = Car.Price
        cbYear.Text = Car.Year
        chbNew.Checked = Car.carNew

        lblDisplay.Text = Car.GetSalutation()


    End Sub


End Class


