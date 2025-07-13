namespace AssetTool
{
    [JsonAsset("WebAPIDefinition")]
    public class UWebAPIDefinition : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}