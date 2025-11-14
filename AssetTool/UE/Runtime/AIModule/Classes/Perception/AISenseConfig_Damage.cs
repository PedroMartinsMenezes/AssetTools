namespace AssetTool
{
    [JsonAsset("AISenseConfig_Damage")]
    public class UAISenseConfig_Damage : UAISenseConfig
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}