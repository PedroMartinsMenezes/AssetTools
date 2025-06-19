namespace AssetTool
{
    [JsonAsset("AssetDefinition_NiagaraScript")]
    public class UAssetDefinition_NiagaraScript : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}