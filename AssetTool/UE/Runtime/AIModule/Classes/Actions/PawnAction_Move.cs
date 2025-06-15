namespace AssetTool
{
    [JsonAsset("DEPRECATED_PawnAction_Move")]
    public class UDEPRECATED_PawnAction_Move : UDEPRECATED_PawnAction
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}