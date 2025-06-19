namespace AssetTool
{
    [JsonAsset("AISenseConfig_Touch")]
    public class UAISenseConfig_Touch : UAISenseConfig
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}