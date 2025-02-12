using System;
using LeaveManagementSystem.Application.Models.LeaveRequests;

namespace LeaveManagementSystem.Application.Services.LeaveRequests;

public interface ILeaveRequestsService
{
    Task CreateLeaveRequest(LeaveRequestCreateVM model); 
    Task<List<LeaveRequestReadOnlyVM>> GetEmployeeLeaveRequests(); 
    Task CancelLeaveRequest(int leaveRequestId);
    Task ReviewLeaveRequest(int LeaveRequestId, bool approved);
    Task<bool> RequestDatesExceedAllocation(LeaveRequestCreateVM model); 
    Task<EmployeeLeaveRequestListVM> AdminGetAllLeaveRequests();
    Task<ReviewLeaveRequestVM> GetLeaveRequestToReview(int leaveRequestId);

}