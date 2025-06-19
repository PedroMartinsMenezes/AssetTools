namespace AssetTool
{
    [JsonAsset("LocalPlayer")]
    public class ULocalPlayer : UPlayer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}