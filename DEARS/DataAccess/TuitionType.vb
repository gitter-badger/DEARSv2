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

Partial Public Class TuitionType
	Implements IEquatable(Of TuitionType)

	Function Equals1(other as TuitionType) as Boolean Implements IEquatable(Of TuitionType).Equals
		
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
