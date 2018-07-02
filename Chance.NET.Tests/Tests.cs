﻿using System;
using System.Text;
using System.Collections.Generic;

using NUnit.Framework;

namespace ChanceNET.Tests
{
	/// <summary>
	/// Summary description for SerializationTests
	/// </summary>
	[TestFixture]
	public class Tests
	{
		Chance chance = new Chance();

		static IEnumerable<int> LoopTestSource()
		{
			for (int i = 0; i < 10000; i++)
			{
				yield return i;
			}
		}

		[Test, TestCaseSource("LoopTestSource")]
		public void LocationTests(int i)
		{
			Location loc = chance.Location();

			Assert.IsTrue(loc.Latitude != 0 && loc.Latitude >= -90 && loc.Latitude <= 90);
			Assert.IsTrue(loc.Longitude != 0 && loc.Longitude >= -180 && loc.Longitude <= 180);

			double distance = loc.DistanceTo(loc);

			Assert.AreEqual(0, distance);

			Location other = chance.Location(loc, 1000);
			Assert.IsTrue(loc.DistanceTo(other) < 1000);
		}

		[Test, TestCaseSource("LoopTestSource")]
		public void SerializationTests(int i)
		{
			Book b = chance.Object<Book>();

			Assert.IsTrue(b.Year > 0);
			Assert.IsTrue(b.Price >= 0 && b.Price < 100);
			Assert.IsTrue(b.Release != default(DateTime));
			Assert.IsFalse(string.IsNullOrWhiteSpace(b.Title));
			Assert.IsFalse(string.IsNullOrWhiteSpace(b.Guid));
			Assert.IsFalse(string.IsNullOrWhiteSpace(b.CoverColor));
			Assert.IsTrue(b.CoverColor.StartsWith("#"));
			Assert.IsFalse(string.IsNullOrWhiteSpace(b.Author.Email));
			Assert.IsFalse(string.IsNullOrWhiteSpace(b.Author.FirstName));
			Assert.IsFalse(string.IsNullOrWhiteSpace(b.Author.FullName()));
			Assert.IsFalse(string.IsNullOrWhiteSpace(b.Author.LastName));
			Assert.IsTrue(b.Location.Latitude != 0 && b.Location.Latitude >= -90 && b.Location.Latitude <= 90);
			Assert.IsTrue(b.Location.Longitude != 0 && b.Location.Longitude >= -180 && b.Location.Longitude <= 180);
			Assert.IsTrue(Uri.IsWellFormedUriString(b.Website, UriKind.Absolute));
		}

		[TearDown]
		public void Reset()
		{
			chance = chance.New();
		}
	}
}