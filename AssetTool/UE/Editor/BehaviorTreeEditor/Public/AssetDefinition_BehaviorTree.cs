namespace AssetTool
{
    [JsonAsset("AssetDefinition_BehaviorTree")]
    public class UAssetDefinition_BehaviorTree : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}