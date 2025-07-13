namespace AssetTool
{
    [JsonAsset("NNERuntimeORTSettings")]
    public class UNNERuntimeORTSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}