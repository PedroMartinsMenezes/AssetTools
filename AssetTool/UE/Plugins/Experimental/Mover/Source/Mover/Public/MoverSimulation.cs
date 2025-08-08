namespace AssetTool
{
    [JsonAsset("MoverSimulation")]
    public class UMoverSimulation : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}