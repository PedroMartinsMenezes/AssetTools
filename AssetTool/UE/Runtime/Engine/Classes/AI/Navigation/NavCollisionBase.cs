namespace AssetTool
{
    [JsonAsset("NavCollisionBase")]
    public class UNavCollisionBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}