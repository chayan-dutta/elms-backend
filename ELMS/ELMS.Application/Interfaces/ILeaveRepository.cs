using ELMS.Application.DTOs;

namespace ELMS.Application.Interfaces;

public interface ILeaveRepository
{
    public Guid ApplyForLeave(LeaveRequestDto leaveRequest)
}
