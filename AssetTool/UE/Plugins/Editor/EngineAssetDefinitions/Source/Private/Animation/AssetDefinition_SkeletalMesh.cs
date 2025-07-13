namespace AssetTool
{
    [JsonAsset("AssetDefinition_SkeletalMesh")]
    public class UAssetDefinition_SkeletalMesh : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}