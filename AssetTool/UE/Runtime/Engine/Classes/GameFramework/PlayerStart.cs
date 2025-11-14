namespace AssetTool
{
    [JsonAsset("PlayerStart")]
    public class APlayerStart : ANavigationObjectBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}