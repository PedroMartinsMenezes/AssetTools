namespace AssetTool
{
    [JsonAsset("AssetDefinition_Blackboard")]
    public class UAssetDefinition_Blackboard : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}