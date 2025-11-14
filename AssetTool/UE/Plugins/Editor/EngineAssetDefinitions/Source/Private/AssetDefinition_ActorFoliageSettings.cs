namespace AssetTool
{
    [JsonAsset("AssetDefinition_ActorFoliageSettings")]
    public class UAssetDefinition_ActorFoliageSettings : UAssetDefinitionDefault
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}