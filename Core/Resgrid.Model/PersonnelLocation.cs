﻿using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Resgrid.Model.Repositories;

namespace Resgrid.Model
{
	[BsonCollection("personnelLocations")]
	public class PersonnelLocation : NoSqlDocument
	{
		[BsonElement("departmentId")]
		public int DepartmentId { get; set; }

		[Required]
		[BsonElement("userId")]
		public string UserId { get; set; }

		[BsonElement("timestamp")]
		public DateTime Timestamp { get; set; }

		[BsonElement("latitude")]
		public decimal Latitude { get; set; }

		[BsonElement("longitude")]
		public decimal Longitude { get; set; }

		[BsonElement("accuracy")]
		public decimal? Accuracy { get; set; }

		[BsonElement("altitude")]
		public decimal? Altitude { get; set; }

		[BsonElement("altitudeAccuracy")]
		public decimal? AltitudeAccuracy { get; set; }

		[BsonElement("speed")]
		public decimal? Speed { get; set; }

		[BsonElement("heading")]
		public decimal? Heading { get; set; }
	}
}
