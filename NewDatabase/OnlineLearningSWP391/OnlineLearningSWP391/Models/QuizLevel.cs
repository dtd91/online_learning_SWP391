﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class QuizLevel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
