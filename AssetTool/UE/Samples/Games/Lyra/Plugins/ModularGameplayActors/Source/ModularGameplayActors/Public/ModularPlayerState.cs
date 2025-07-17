namespace AssetTool
{
    [JsonAsset("ModularPlayerState")]
    public class AModularPlayerState : APlayerState
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}