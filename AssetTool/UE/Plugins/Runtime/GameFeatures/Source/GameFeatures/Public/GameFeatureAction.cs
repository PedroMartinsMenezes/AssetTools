namespace AssetTool
{
    [JsonAsset("GameFeatureAction")]
    public class UGameFeatureAction : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}