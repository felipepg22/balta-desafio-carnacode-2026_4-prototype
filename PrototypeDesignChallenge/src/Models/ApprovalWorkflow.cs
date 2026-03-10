using PrototypeDesignChallenge.Models.Interfaces;

namespace PrototypeDesignChallenge.Models;

public class ApprovalWorkflow : IPrototype
{
    public List<string> Approvers { get; set; }
    public int RequiredApprovals { get; set; }
    public int TimeoutDays { get; set; }

    public ApprovalWorkflow()
    {
        Approvers = new List<string>();
    }

    public IPrototype Clone()
    {
        return new ApprovalWorkflow
        {
            Approvers = this.Approvers,
            RequiredApprovals =  this.RequiredApprovals,
            TimeoutDays = this.TimeoutDays
        };
    }
}