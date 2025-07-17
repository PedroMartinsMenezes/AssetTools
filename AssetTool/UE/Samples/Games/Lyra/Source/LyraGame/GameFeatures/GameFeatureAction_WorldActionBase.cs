namespace AssetTool
{
    [JsonAsset("GameFeatureAction_WorldActionBase")]
    public class UGameFeatureAction_WorldActionBase : UGameFeatureAction
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}