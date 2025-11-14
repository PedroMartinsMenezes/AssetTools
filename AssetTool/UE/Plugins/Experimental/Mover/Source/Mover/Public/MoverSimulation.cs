namespace AssetTool
{
    [JsonAsset("MoverSimulation")]
    public class UMoverSimulation : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}