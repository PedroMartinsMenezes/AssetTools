namespace AssetTool
{
    [JsonAsset("CommonLocalPlayer")]
    public class UCommonLocalPlayer : ULocalPlayer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}