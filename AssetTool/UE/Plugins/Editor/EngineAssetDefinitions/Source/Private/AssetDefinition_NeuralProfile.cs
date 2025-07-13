namespace AssetTool
{
    [JsonAsset("AssetDefinition_NeuralProfile")]
    public class UAssetDefinition_NeuralProfile : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}