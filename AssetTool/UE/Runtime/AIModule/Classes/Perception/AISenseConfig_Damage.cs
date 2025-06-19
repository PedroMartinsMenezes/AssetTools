namespace AssetTool
{
    [JsonAsset("AISenseConfig_Damage")]
    public class UAISenseConfig_Damage : UAISenseConfig
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}