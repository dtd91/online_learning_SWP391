﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public enum SortOrder { Asc=0,Desc=1 }
    public class Course
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime Created_Date { get; set; }
        [Required]
        public string Description { get; set; }
        public int Featured { get; set; }
        
        [Display(Name = "Short Description")]
        public string Short_Description { get; set; }
        [Display(Name = "Thumbnail URL")]
        [MaxLength(256, ErrorMessage = "Not exceed 256")]
        public string Thumbnail_URL { get; set; }
        [NotMapped]
        [DisplayName("Upload Img")]
        public IFormFile ImgFile { get; set; }
        [Required]
        [MaxLength(256, ErrorMessage = "Not exceed 256")]
        public string Title { get; set; }
        [DisplayName("Category")]
        public int Category_Id { get; set; }
        [DisplayName("Status")]
        public int Status_Id { get; set; }

        [ForeignKey("Category_Id")]
        public virtual Category Category { get; set; }
        [ForeignKey("Status_Id")]
        public virtual Status Status { get; set; }

        public List<Owner> Owners { get; set; }

        public List<Course_Package> Course_Packages { get; set; }

        public List<Course_Dimension> Course_Dimensions { get; set; }
    }
}
