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

Partial Public Class ExamType
	Implements IEquatable(Of ExamType)

	Function Equals1(other as ExamType) as Boolean Implements IEquatable(Of ExamType).Equals
		
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

End Class
