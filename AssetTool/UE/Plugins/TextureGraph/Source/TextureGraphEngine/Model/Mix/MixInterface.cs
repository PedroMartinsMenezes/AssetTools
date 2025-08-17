namespace AssetTool
{
    [JsonAsset("MixInterface")]
    public class UMixInterface : UModelObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}