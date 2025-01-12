﻿namespace RaqamliAvlod.Application.ViewModels.Contests.Commands
{
    public class ContestCreateViewModel
    {
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsPublic { get; set; }
    }
}
