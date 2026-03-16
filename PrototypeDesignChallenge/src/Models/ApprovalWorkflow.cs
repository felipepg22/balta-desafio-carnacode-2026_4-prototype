using PrototypeDesignChallenge.Models.Interfaces;

namespace PrototypeDesignChallenge.Models;

public class ApprovalWorkflow : IPrototype<ApprovalWorkflow>
{
    public List<string> Approvers { get; set; }
    public int RequiredApprovals { get; set; }
    public int TimeoutDays { get; set; }

    public ApprovalWorkflow()
    {
        Approvers = new List<string>();
    }

    public ApprovalWorkflow Clone()
    {
        return new ApprovalWorkflow
        {
            Approvers = new List<string>(this.Approvers),
            RequiredApprovals = this.RequiredApprovals,
            TimeoutDays = this.TimeoutDays
        };
    }
}