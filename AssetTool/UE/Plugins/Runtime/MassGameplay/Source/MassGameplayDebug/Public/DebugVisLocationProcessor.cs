namespace AssetTool
{
    [JsonAsset("DebugVisLocationProcessor")]
    public class UDebugVisLocationProcessor : UMassProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassProcessor_UpdateDebugVis")]
    public class UMassProcessor_UpdateDebugVis : UMassProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}