namespace AssetTool
{
    [JsonAsset("WebAPICodeGeneratorBase")]
    public class UWebAPICodeGeneratorBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}