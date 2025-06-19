namespace AssetTool
{
    [JsonAsset("SmokeTestCommandlet")]
    public class USmokeTestCommandlet : UCommandlet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}