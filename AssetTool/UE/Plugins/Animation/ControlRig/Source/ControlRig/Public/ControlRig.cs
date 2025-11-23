namespace AssetTool
{
    [JsonAsset("ControlRig")]
    public class UControlRig : UObject
    {
        public List<FRigPhysicsSolverDescription> PhysicsSolvers;

        public override ITransferable Move(Transfer transfer)
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