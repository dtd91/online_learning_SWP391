﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391.Models
{
	[Table("Quizzes")]
	public class Quiz
	{
		public string QuizId { get; set; }
		public string Description { get; set; }
		public int Duration { get; set; }
		public string Name { get; set; }
		public int QuestionNum { get; set; }
		public virtual Course Course { get; set; }
		public string CourseId { get; set; }
		public ICollection<Attempt> Attempts { get; set; }
		public ICollection<QuizQuestion> QuizQuestions { get; set; }
		public virtual QuizType QuizType { get; set; }
		public string QuizTypeId { get; set; }
		public virtual QuizLevel QuizLevel { get; set; }
		public string QuizLevelId { get; set; }

	}
}
