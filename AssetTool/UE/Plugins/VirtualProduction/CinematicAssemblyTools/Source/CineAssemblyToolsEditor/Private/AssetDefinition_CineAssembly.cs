namespace AssetTool
{
    [JsonAsset("AssetDefinition_CineAssembly")]
    public class UAssetDefinition_CineAssembly : UAssetDefinition_LevelSequence
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}