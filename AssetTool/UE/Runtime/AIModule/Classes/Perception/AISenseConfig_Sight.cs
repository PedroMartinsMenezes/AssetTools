namespace AssetTool
{
    [JsonAsset("AISenseConfig_Sight")]
    public class UAISenseConfig_Sight : UAISenseConfig
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}