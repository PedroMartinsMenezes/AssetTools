namespace AssetTool
{
    [JsonAsset("ControlRig")]
    public class UControlRig : URigVMHost
    {
        public List<FRigPhysicsSolverDescription> PhysicsSolvers;

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.Supports.ControlRigStoresPhysicsSolvers)
            {
                transfer.Move(ref PhysicsSolvers);
            }
            return this;
        }
    }
}