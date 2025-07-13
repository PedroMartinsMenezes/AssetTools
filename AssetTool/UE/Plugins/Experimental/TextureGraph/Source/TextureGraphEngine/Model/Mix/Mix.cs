namespace AssetTool
{
    [JsonAsset("Mix")]
    public class UMix : UMixInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}