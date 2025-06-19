namespace AssetTool
{
    [JsonAsset("NavCollisionBase")]
    public class UNavCollisionBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}