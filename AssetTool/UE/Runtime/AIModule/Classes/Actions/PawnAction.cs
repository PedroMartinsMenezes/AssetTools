namespace AssetTool
{
    [JsonAsset("PawnAction")]
    public class UDEPRECATED_PawnAction : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}