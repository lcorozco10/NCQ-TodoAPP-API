﻿using NCQ.Todo.App.Domain.Entities;

namespace NCQ.Todo.App.Application.Features.TaskFeature.CreateTask
{
    public sealed record CreateTaskResponse
    {
        public Guid? Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public Domain.Entities.TaskStatus Status { get; set; } = Domain.Entities.TaskStatus.Pending;
        public TaskPripriority? PripriorityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid? CollaboratorId { get; set; }
        public string Notes { get; set; } = string.Empty;
    }
}
