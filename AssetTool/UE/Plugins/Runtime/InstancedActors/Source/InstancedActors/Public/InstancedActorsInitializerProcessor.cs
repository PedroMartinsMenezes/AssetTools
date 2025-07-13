namespace AssetTool
{
    [JsonAsset("InstancedActorsInitializerProcessor")]
    public class UInstancedActorsInitializerProcessor : UMassProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}