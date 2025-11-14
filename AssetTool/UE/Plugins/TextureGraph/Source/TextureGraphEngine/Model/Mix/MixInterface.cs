namespace AssetTool
{
    [JsonAsset("MixInterface")]
    public class UMixInterface : UModelObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}