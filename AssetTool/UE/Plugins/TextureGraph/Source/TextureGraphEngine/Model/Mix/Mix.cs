namespace AssetTool
{
    [JsonAsset("Mix")]
    public class UMix : UMixInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}