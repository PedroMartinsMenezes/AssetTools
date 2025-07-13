namespace AssetTool
{
    [JsonAsset("InstancedActorsData")]
    public class UInstancedActorsData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}