namespace AssetTool
{
    [JsonAsset("TG_Pin")]
    public class UTG_Pin : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}