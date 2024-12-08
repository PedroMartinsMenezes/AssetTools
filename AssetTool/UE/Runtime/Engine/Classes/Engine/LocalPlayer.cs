namespace AssetTool
{
    [JsonAsset("LocalPlayer")]
    public class ULocalPlayer : UPlayer
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}