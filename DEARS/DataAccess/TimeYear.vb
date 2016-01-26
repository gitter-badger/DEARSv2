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

Partial Public Class TimeYear
	Implements IEquatable(Of TimeYear)

	Function Equals1(other as TimeYear) as Boolean Implements IEquatable(Of TimeYear).Equals
		
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
    Public Property NameEnglish As String
    Public Property NameArabic As String

    Public Overridable Property BatchEnrollments As ICollection(Of BatchEnrollment) = New HashSet(Of BatchEnrollment)
    Public Overridable Property Batches As ICollection(Of Batch) = New HashSet(Of Batch)
    Public Overridable Property CourseDisciplines As ICollection(Of CourseDiscipline) = New HashSet(Of CourseDiscipline)
    Public Overridable Property CourseEnrollments As ICollection(Of CourseEnrollment) = New HashSet(Of CourseEnrollment)
    Public Overridable Property CourseTeachers As ICollection(Of CourseTeacher) = New HashSet(Of CourseTeacher)
    Public Overridable Property GPAwRecomms As ICollection(Of GPAwRecomm) = New HashSet(Of GPAwRecomm)
    Public Overridable Property MarksExamCWs As ICollection(Of MarksExamCW) = New HashSet(Of MarksExamCW)
    Public Overridable Property OfferedCourses As ICollection(Of OfferedCourse) = New HashSet(Of OfferedCourse)
    Public Overridable Property OfferedDisciplines As ICollection(Of OfferedDiscipline) = New HashSet(Of OfferedDiscipline)
    Public Overridable Property SemesterBatchEnrollments As ICollection(Of SemesterBatchEnrollment) = New HashSet(Of SemesterBatchEnrollment)
    Public Overridable Property SemesterBatches As ICollection(Of SemesterBatch) = New HashSet(Of SemesterBatch)

End Class
