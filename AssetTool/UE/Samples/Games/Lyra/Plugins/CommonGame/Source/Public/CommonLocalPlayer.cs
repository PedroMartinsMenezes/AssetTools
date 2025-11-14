namespace AssetTool
{
    [JsonAsset("CommonLocalPlayer")]
    public class UCommonLocalPlayer : ULocalPlayer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}