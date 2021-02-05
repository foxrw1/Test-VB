Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Variables are used to hold a value in a program.
        'The value of the variable can change over time.
        'Variables are always given a name and must be declared
        'before use.

        'Example:
        Dim length As Double
        Dim width As Double

        'I use Dim to create a variable
        'I must provide a name (I choose) and a data type

        'Legal Names For Variables
        '1.Contain no spaces or punctuations
        '2.Contain only letters and numbers
        '3.Must start w/ letter
        '4.Underscores are ok
        '5. Can't be reserved (blue) words 
        'like sub, Double, etc.


        'Other types of data
        '1. Integer (pos/neg whole #s)
        '2. Double (pos/neg decimal numbers)
        '3. String (text)



        'Get length and width from the user
        'i.e fill our variables with a value
        length = TextBox1.Text
        width = TextBox2.Text


        'Calculate (+, -, *, /, ^, () ) VB knows the 
        'order of operations
        Dim area As Double
        area = length * width


        'Formatting output (pick 1 of the 3)
        '***********************************
        'Output the results to the user
        'w/no formatting
        Label4.Text = area

        'output formatted to 3 decimal places
        Label4.Text = Format(area, "##.###")

        'output as currency
        Label4.Text = Format(area, "Currency")



        'not the same as area = label4.text

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'Determine if the checkbox is checked
        If CheckBox1.Checked = True Then
            Button2.Text = "YES"
        End If

    End Sub
End Class
