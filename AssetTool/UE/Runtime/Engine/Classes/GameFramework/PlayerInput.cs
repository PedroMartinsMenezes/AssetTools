namespace AssetTool
{
    [JsonAsset("PlayerInput")]
    public class UPlayerInput : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}