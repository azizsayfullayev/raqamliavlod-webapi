﻿namespace RaqamliAvlod.Application.ViewModels.Courses.Queries
{
    public class CourseCommentViewModel
    {
        public long Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string CommentText { get; set; } = string.Empty;

        public long CourseId { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
