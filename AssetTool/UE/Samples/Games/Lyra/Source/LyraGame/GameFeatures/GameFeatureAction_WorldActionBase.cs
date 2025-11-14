namespace AssetTool
{
    [JsonAsset("GameFeatureAction_WorldActionBase")]
    public class UGameFeatureAction_WorldActionBase : UGameFeatureAction
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}