'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Teacher
	Implements IEquatable(Of Teacher)

	Function Equals1(other as Teacher) as Boolean Implements IEquatable(Of Teacher).Equals
		
		 If DirectCast(Me, Object).Equals(DirectCast(other, Object)) Then
            Return True
        Else
			If {		     Me.Id,other.Id}.Any(Function(s) s = 0) Then 
Return False
End If
		    Return (Me.Id = other.Id)
		End If	
		'Return (Me.Id = other.Id)	
	End Function
    Public Property Id As Integer
    Public Property NameArabic As String
    Public Property NameEnglish As String

    Public Overridable Property CourseTeachers As ICollection(Of CourseTeacher) = New HashSet(Of CourseTeacher)

End Class
