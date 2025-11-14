namespace AssetTool
{
    [JsonAsset("AssetDefinition_SkeletalMesh")]
    public class UAssetDefinition_SkeletalMesh : UAssetDefinitionDefault
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}