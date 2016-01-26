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

Partial Public Class Batch
	Implements IEquatable(Of Batch)

	Function Equals1(other as Batch) as Boolean Implements IEquatable(Of Batch).Equals
		
		 If DirectCast(Me, Object).Equals(DirectCast(other, Object)) Then
            Return True
        Else
			If {		     Me.YearId,other.YearId,Me.GradeId,other.GradeId}.Any(Function(s) s = 0) Then 
Return False
End If
		    Return (Me.YearId = other.YearId) And(Me.GradeId = other.GradeId)
		End If	
		'Return (Me.YearId = other.YearId) And(Me.GradeId = other.GradeId)	
	End Function
    Public Property YearId As Integer
    Public Property GradeId As Integer
    Public Property NameEnglish As String
    Public Property NameArabic As String

    Public Overridable Property BatchEnrollments As ICollection(Of BatchEnrollment) = New HashSet(Of BatchEnrollment)
    Public Overridable Property Grade As Grade
    Public Overridable Property TimeYear As TimeYear
    Public Overridable Property SemesterBatches As ICollection(Of SemesterBatch) = New HashSet(Of SemesterBatch)
    Public Overridable Property GPAwRecomms As ICollection(Of GPAwRecomm) = New HashSet(Of GPAwRecomm)

End Class
