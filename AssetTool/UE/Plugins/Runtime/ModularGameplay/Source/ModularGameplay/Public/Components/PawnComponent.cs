namespace AssetTool
{
    [JsonAsset("PawnComponent")]
    public class UPawnComponent : UGameFrameworkComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}