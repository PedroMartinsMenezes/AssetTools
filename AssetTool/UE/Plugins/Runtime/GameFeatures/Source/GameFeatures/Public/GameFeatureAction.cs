namespace AssetTool
{
    [JsonAsset("GameFeatureAction")]
    public class UGameFeatureAction : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}