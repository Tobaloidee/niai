﻿using System.Collections.Generic;

namespace Niai.Models
{
	public class Kanji
	{
		public string Character { get; set; }

		public List<string> Meanings { get; set; }

		public string Onyomi { get; set; }

		public string Kunyomi { get; set; }

		public int? WaniKaniLevel { get; set; }

		public List<string> Tags { get; set; }

		public int? Frequency { get; set; }

		public int Strokes { get; set; }

		public int? Jlpt { get; set; }

		public int? Grade { get; set; }

		public List<string> Similar { get; set; }
	}
}
