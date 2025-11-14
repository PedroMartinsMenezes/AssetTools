namespace AssetTool
{
    [JsonAsset("AssetDefinition_AnimBlueprint")]
    public class UAssetDefinition_AnimBlueprint : UAssetDefinition_Blueprint
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}