﻿using RaqamliAvlod.Domain.Entities.Courses;
using RaqamliAvlod.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaqamliAvlod.Application.ViewModels.Courses.Commands
{
    public class CourseCommentViewModel
    {
        public string CommentText { get; set; } = String.Empty;

        public long CourseId { get; set; }
    }
}
