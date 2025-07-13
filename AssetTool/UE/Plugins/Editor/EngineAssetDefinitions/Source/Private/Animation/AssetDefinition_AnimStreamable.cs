namespace AssetTool
{
    [JsonAsset("AssetDefinition_AnimStreamable")]
    public class UAssetDefinition_AnimStreamable : UAssetDefinition_AnimationAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}