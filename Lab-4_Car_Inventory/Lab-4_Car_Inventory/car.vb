Option Strict On

''' <summary>
''' Name:  Ritu Patel
''' Date:  july 11,2019
''' Description: The purpose of this lab is to understand the class.
''' </summary>
Public Class car


    Private Shared carCount As Integer
    Private customerIdentificationNumber As Integer = 0
    Private carMake As String = String.Empty
    Private carModel As String = String.Empty
    Private carYear As String = String.Empty
    Private carPrice As String = String.Empty
    Private carStatus As Boolean = False


    Public Sub New()

        carCount += 1
        customerIdentificationNumber = carCount

    End Sub


    Public Sub New(Make As String, Model As String, Year As String, Price As String, carNew As Boolean)

        Me.New()


        carMake = Make
        carModel = Model
        carYear = Year
        carPrice = Price

        carStatus = carNew

    End Sub



    Public ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property

    Public ReadOnly Property IdentificationNumber() As Integer
        Get
            Return customerIdentificationNumber
        End Get
    End Property


    Public Property carNew() As Boolean
        Get
            Return carStatus
        End Get
        Set(ByVal value As Boolean)
            carStatus = value
        End Set
    End Property

    ''' <summary>
    ''' Title property - Gets and Sets the title of a customer
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(ByVal value As String)
            carMake = value
        End Set
    End Property


    Public Property Price() As String
        Get
            Return carPrice
        End Get
        Set(ByVal value As String)
            carPrice = value
        End Set
    End Property

    ''' <summary>
    ''' FirstName property - Gets and Sets the first name of a customer
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(ByVal value As String)
            carModel = value
        End Set
    End Property

    Public Property Year() As String
        Get
            Return carYear
        End Get
        Set(ByVal value As String)
            carYear = value
        End Set
    End Property


    ''' <summary>
    ''' GetSalutation is a function that a salutation based on the private properties within the class scope
    ''' </summary>
    ''' <returns>String</returns>
    Public Function GetSalutation() As String

        Return ("It worked!").ToString()

    End Function


End Class


