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

Partial Public Class BatchEnrollment
	Implements IEquatable(Of BatchEnrollment)

	Function Equals1(other as BatchEnrollment) as Boolean Implements IEquatable(Of BatchEnrollment).Equals
		
		 If DirectCast(Me, Object).Equals(DirectCast(other, Object)) Then
            Return True
        Else
			If {		     Me.YearId,other.YearId,Me.GradeId,other.GradeId,Me.StudentId,other.StudentId,Me.EnrollmentTypeId,other.EnrollmentTypeId}.Any(Function(s) s = 0) Then 
Return False
End If
		    Return (Me.YearId = other.YearId) And(Me.GradeId = other.GradeId) And(Me.StudentId = other.StudentId) And(Me.EnrollmentTypeId = other.EnrollmentTypeId)
		End If	
		'Return (Me.YearId = other.YearId) And(Me.GradeId = other.GradeId) And(Me.StudentId = other.StudentId)	
	End Function
    Public Property YearId As Integer
    Public Property GradeId As Integer
    Public Property StudentId As Integer
    Public Property EnrollmentTypeId As Integer = 1

    Public Overridable Property Grade As Grade
    Public Overridable Property Student As Student
    Public Overridable Property TimeYear As TimeYear
    Public Overridable Property SemesterBatchEnrollments As ICollection(Of SemesterBatchEnrollment) = New HashSet(Of SemesterBatchEnrollment)
    Public Overridable Property Batch As Batch
    Public Overridable Property EnrollmentType As EnrollmentType
    Public Overridable Property GPAwRecomm As GPAwRecomm

End Class
