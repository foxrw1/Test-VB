Public Class Form1


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Square root
        Dim x As Integer
        x = 25
        Label4.Text = Math.Sqrt(x)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Absolute value
        Dim x As Integer
        x = -10
        Label4.Text = Math.Abs(x)
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Input Step

        'Variables are used by programs to hold information
        'Think of variables like little containers
        'The value of variables can change over time

        'Create variables for the length and width
        Dim length As Double
        Dim width As Double

        'Dim (dimension) is what creates a variable
        'length and width are the names I have given to my variables (my choice)
        '

        'Legal identifiers for variables
        '1. Contain no spaces
        '2. Contain only letters and numbers 
        '3. Must start with a letter
        '4. Underscores are fine
        '5. Can't be a reserved word (in blue)

        'Other types of variables
        '1. Integer (pos/neg whole number)
        '2. Double (pos/neg numbers that contain a decimal point)
        '3. String (text)


        'Input from the textboxes
        length = TextBox1.Text
        width = TextBox2.Text

        'Compute Area
        Dim area As Double
        area = length * width
        'Math Operations: +, -, *, /, ^, ()

        'Output step
        'Label4.Text = area

        'Output area formatted to 3 decimal places
        'Label4.Text = Format(area, "0.000")

        'Output area formatted as currency
        Label4.Text = Format(area, "currency")








    End Sub
End Class
