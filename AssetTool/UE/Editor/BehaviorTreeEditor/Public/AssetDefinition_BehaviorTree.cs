namespace AssetTool
{
    [JsonAsset("AssetDefinition_BehaviorTree")]
    public class UAssetDefinition_BehaviorTree : UAssetDefinitionDefault
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}