using LeaveManagementSystem.Application.Models.LeaveTypes;

namespace LeaveManagementSystem.Application.Services.LeaveTypes;

public interface ILeaveTypesService
{
    Task<List<LeaveTypeReadOnlyVM>> GetAllLeaveTypes();
    Task<T?> Get<T>(int id) where T : class;
    Task Remove(int id);
    Task Edit(LeaveTypeEditVM model);
    Task Create(LeaveTypeCreateVM model);
    bool LeaveTypeExists(int id);
    Task<bool> CheckIfLeaveTypeNameExists(string name);
    Task<bool> CheckIfLeaveTypeNameExistsForEdit(LeaveTypeEditVM leaveTypeEdit);
    Task<bool> DaysExceedMaximum(int leaveTypeId, int days);
    
}
