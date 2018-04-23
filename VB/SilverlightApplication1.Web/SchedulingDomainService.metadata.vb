Imports Microsoft.VisualBasic
	Imports System
	Imports System.Collections.Generic
	Imports System.ComponentModel
	Imports System.ComponentModel.DataAnnotations
	Imports System.Linq
	Imports System.ServiceModel.DomainServices.Hosting
	Imports System.ServiceModel.DomainServices.Server
Namespace SilverlightApplication1.Web


	' The MetadataTypeAttribute identifies CarSchedulingMetadata as the class
	' that carries additional metadata for the CarScheduling class.
	<MetadataTypeAttribute(GetType(CarScheduling.CarSchedulingMetadata))> _
	Partial Public Class CarScheduling

		' This class allows you to attach custom attributes to properties
		' of the CarScheduling class.
		'
		' For example, the following marks the Xyz property as a
		' required property and specifies the format for valid values:
		'    [Required]
		'    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		'    [StringLength(32)]
		'    public string Xyz { get; set; }
		Friend NotInheritable Class CarSchedulingMetadata

			' Metadata classes are not meant to be instantiated.
			Private Sub New()
			End Sub

			Private privateAllDay As Boolean
			Public Property AllDay() As Boolean
				Get
					Return privateAllDay
				End Get
				Set(ByVal value As Boolean)
					privateAllDay = value
				End Set
			End Property

			Private privateCarId? As Integer
			Public Property CarId() As Integer?
				Get
					Return privateCarId
				End Get
				Set(ByVal value? As Integer)
					privateCarId = value
				End Set
			End Property

			Private privateContactInfo As String
			Public Property ContactInfo() As String
				Get
					Return privateContactInfo
				End Get
				Set(ByVal value As String)
					privateContactInfo = value
				End Set
			End Property

			Private privateDescription As String
			Public Property Description() As String
				Get
					Return privateDescription
				End Get
				Set(ByVal value As String)
					privateDescription = value
				End Set
			End Property

			Private privateEndTime? As DateTime
			Public Property EndTime() As DateTime?
				Get
					Return privateEndTime
				End Get
				Set(ByVal value? As DateTime)
					privateEndTime = value
				End Set
			End Property

			Private privateEventType? As Integer
			Public Property EventType() As Integer?
				Get
					Return privateEventType
				End Get
				Set(ByVal value? As Integer)
					privateEventType = value
				End Set
			End Property

			Private privateID As Integer
			Public Property ID() As Integer
				Get
					Return privateID
				End Get
				Set(ByVal value As Integer)
					privateID = value
				End Set
			End Property

			Private privateLabel? As Integer
			Public Property Label() As Integer?
				Get
					Return privateLabel
				End Get
				Set(ByVal value? As Integer)
					privateLabel = value
				End Set
			End Property

			Private privateLocation As String
			Public Property Location() As String
				Get
					Return privateLocation
				End Get
				Set(ByVal value As String)
					privateLocation = value
				End Set
			End Property

			Private privatePrice? As Decimal
			Public Property Price() As Decimal?
				Get
					Return privatePrice
				End Get
				Set(ByVal value? As Decimal)
					privatePrice = value
				End Set
			End Property

			Private privateRecurrenceInfo As String
			Public Property RecurrenceInfo() As String
				Get
					Return privateRecurrenceInfo
				End Get
				Set(ByVal value As String)
					privateRecurrenceInfo = value
				End Set
			End Property

			Private privateReminderInfo As String
			Public Property ReminderInfo() As String
				Get
					Return privateReminderInfo
				End Get
				Set(ByVal value As String)
					privateReminderInfo = value
				End Set
			End Property

			Private privateStartTime? As DateTime
			Public Property StartTime() As DateTime?
				Get
					Return privateStartTime
				End Get
				Set(ByVal value? As DateTime)
					privateStartTime = value
				End Set
			End Property

			Private privateStatus? As Integer
			Public Property Status() As Integer?
				Get
					Return privateStatus
				End Get
				Set(ByVal value? As Integer)
					privateStatus = value
				End Set
			End Property

			Private privateSubject As String
			Public Property Subject() As String
				Get
					Return privateSubject
				End Get
				Set(ByVal value As String)
					privateSubject = value
				End Set
			End Property

			Private privateUserId? As Integer
			Public Property UserId() As Integer?
				Get
					Return privateUserId
				End Get
				Set(ByVal value? As Integer)
					privateUserId = value
				End Set
			End Property
		End Class
	End Class
End Namespace
