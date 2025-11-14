namespace AssetTool
{
    [JsonAsset("ModularPlayerState")]
    public class AModularPlayerState : APlayerState
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}