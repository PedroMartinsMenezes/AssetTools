namespace AssetTool
{
    [JsonAsset("UserToolBoxBaseBlueprint")]
    public class UUserToolBoxBaseBlueprint : UUTBBaseCommand
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}