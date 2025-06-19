namespace AssetTool
{
    [JsonAsset("AISenseConfig_Team")]
    public class UAISenseConfig_Team : UAISenseConfig
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}