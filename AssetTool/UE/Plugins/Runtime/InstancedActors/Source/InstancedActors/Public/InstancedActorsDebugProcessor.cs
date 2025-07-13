namespace AssetTool
{
    [JsonAsset("InstancedActorsDebugProcessor")]
    public class UInstancedActorsDebugProcessor : UMassProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}