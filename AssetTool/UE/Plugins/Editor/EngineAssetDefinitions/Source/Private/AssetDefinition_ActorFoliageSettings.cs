namespace AssetTool
{
    [JsonAsset("AssetDefinition_ActorFoliageSettings")]
    public class UAssetDefinition_ActorFoliageSettings : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}