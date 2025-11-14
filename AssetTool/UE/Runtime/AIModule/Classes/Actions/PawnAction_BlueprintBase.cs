namespace AssetTool
{
    [JsonAsset("PawnAction_BlueprintBase")]
    public class UDEPRECATED_PawnAction_BlueprintBase : UDEPRECATED_PawnAction
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}